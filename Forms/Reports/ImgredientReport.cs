using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.ViewModels;
using System.Data;

namespace Restoran.Forms.Reports
{
    public partial class ImgredientReport : Form
    {
        private List<Menu> _menus;
        private readonly DishIngredientMapper _dishIngredientMapper;

        public ImgredientReport()
        {
            InitializeComponent();

            _dishIngredientMapper = new DishIngredientMapper();

            using (var dbContext = new AppDbContext())
            {
                SetMenus(dbContext, dateTimePicker.Value);
            }
        }

        private void ImgredientReport_Load(object sender, EventArgs e)
        {
            SetIngredients(findTextBox.Text.Trim().ToUpper());
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            SetIngredients(findTextBox.Text.Trim().ToUpper());
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                SetMenus(dbContext, dateTimePicker.Value);
                SetIngredients(findTextBox.Text.Trim().ToUpper());
            }
        }

        private void SetMenus(AppDbContext dbContext, DateTime date)
        {
            _menus = dbContext.Menus.AsNoTracking()
                .Where(menu => date.Date <= menu.Date && menu.Date <= date.Date.AddDays(1))
                .Include(menu => menu.MenuDishes)
                    .ThenInclude(menuDish => menuDish.Dish)
                        .ThenInclude(dish => dish.DishIngredients)
                            .ThenInclude(dishIngredient => dishIngredient.Ingredient)
               .ToList();
        }

        private void SetIngredients(string search)
        {
            var dishIngredients = new List<DishIngredient>();
            var dishIngredientsCount = new Dictionary<Guid, int>();
            foreach (var menu in _menus)
            {
                foreach (var menuDish in menu.MenuDishes)
                {
                    foreach (var dishIngredient in menuDish.Dish.DishIngredients)
                    {
                        if (!dishIngredients.Exists(di => di.IngredientId == dishIngredient.IngredientId))
                        {
                            dishIngredients.Add(dishIngredient);
                            dishIngredientsCount.Add(dishIngredient.IngredientId, menuDish.Count * dishIngredient.Quntity);
                        }
                        else
                        {
                            dishIngredientsCount[dishIngredient.IngredientId] += menuDish.Count * dishIngredient.Quntity;
                        }
                    }
                }
            }

            foreach (var dishIngredient in dishIngredients)
            {
                dishIngredient.Quntity = dishIngredientsCount[dishIngredient.IngredientId];
            }

            if (string.IsNullOrEmpty(search))
            {
                dishIngredientViewModelBindingSource.DataSource = _dishIngredientMapper
                    .Map<DishIngredient, DishIngredientViewModel>(
                        dishIngredients.Where(dishIngredient => 
                            dishIngredient.Ingredient.Name.ToUpper().Contains(search)))
                    .ToList();

                return;
            }

            dishIngredientViewModelBindingSource.DataSource = _dishIngredientMapper
                .Map<DishIngredient, DishIngredientViewModel>(dishIngredients).ToList();
        }
    }
}
