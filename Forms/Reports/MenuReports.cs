using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.ViewModels;
using System.Data;

namespace Restoran.Forms.Reports
{
    public partial class MenuReports : Form
    {
        private List<Menu> _menus;
        private List<Dish> _dishes;
        private readonly List<Category> _categories;
        private readonly DishMapper _dishMapper;

        public MenuReports()
        {
            InitializeComponent();

            _dishMapper = new DishMapper();

            using (var dbContext = new AppDbContext())
            {
                _categories = dbContext.Categories.AsNoTracking().ToList();
                SetMenus(dbContext, DateTime.Now);
            }
        }

        private void MenuReports_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = _categories;
            dateTimePicker.Value = DateTime.Now;
            SetDishes(_categories[0].Id);
        }

        private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current is Category category && category is not null)
            {
                SetDishes(category.Id);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                SetMenus(dbContext, dateTimePicker.Value);
                SetDishes((Guid)categoryComboBox.SelectedValue);
            }
        }

        private void SetMenus(AppDbContext dbContext, DateTime date)
        {
            _menus = dbContext.Menus.AsNoTracking()
                .Where(menu => date.Date <= menu.Date && menu.Date <= date.Date.AddDays(1))
                .Include(menu => menu.Dishes)
                    .ThenInclude(dish => dish.Category)
                .Include(menu => menu.Dishes)
                    .ThenInclude(dish => dish.Authors)
                .ToList();
        }

        private void SetDishes(Guid categoryId)
        {
            _dishes = new List<Dish>();
            if (_menus.Count > 0)
            {
                foreach (var menu in _menus)
                {
                    foreach (var dish in menu.Dishes)
                    {
                        if (!_dishes.Exists(d => d.Id == dish.Id))
                        {
                            _dishes.Add(dish);
                        }
                    }
                }
            }

            dishViewModelBindingSource.DataSource = _dishMapper.Map<Dish, DishViewModel>(
                _dishes.Where(dish => dish.CategoryId == categoryId)).ToList();
        }
    }
}
