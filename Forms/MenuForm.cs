using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Forms
{
    public partial class MenuForm : Form
    {
        private readonly bool _isEdit;
        private readonly AppDbContext _dbContext;
        private readonly Menu _menu;

        private readonly MenuDishMapper _menuDishMapper;

        private readonly List<Dish> _dishes;
        private readonly List<MenuDishViewModel> _menuDishViewModels;

        public MenuForm(Guid? menuId = null)
        {
            InitializeComponent();

            _dbContext = new AppDbContext();
            _menuDishMapper = new MenuDishMapper();
            _dishes = _dbContext.Dishes.AsNoTracking().ToList();

            if (menuId is null)
            {
                _isEdit = false;
                _menu = new Menu
                {
                    Id = Guid.NewGuid(),
                    Date = DateTime.Now
                };
            }
            else
            {
                _isEdit = true;
                _menu = _dbContext.Menus
                    .Include(menu => menu.Dishes)
                    .Include(menu => menu.MenuDishes)
                        .ThenInclude(menuDish => menuDish.Dish)
                    .Single(menu => menu.Id == menuId);

                _menuDishViewModels = _menuDishMapper
                    .Map<MenuDish, MenuDishViewModel>(_menu.MenuDishes).ToList();

                _dishes = _dishes
                    .Where(dish => !_menu.Dishes.Exists(d => d.Id == dish.Id))
                    .ToList();

                Text = "Изменение меню";
                acceptButton.Text = "Изменить";
            }
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            menuBindingSource.DataSource = _menu;
            menuDishViewModelBindingSource.DataSource = _menuDishViewModels;
            dishBindingSource.DataSource = _dishes;
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(compabyNameTextBox.Text))
            {
                MessageBox.Show("Все поля должнв быть заполнены", "Заполните поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true;
                return;
            }

            _menu.Date = dateTimePicker.Value;

            if (_isEdit)
            {
                _dbContext.Menus.Update(_menu);
            }
            else
            {
                _dbContext.Menus.Add(_menu);
            }

            _menu.Dishes.ForEach(dish =>
            {
                _dbContext.Attach(dish);
            });

            _dbContext.SaveChanges();
            _dbContext.Dispose();
        }

        private void dishAddButton_Click(object sender, EventArgs e)
        {
            if (dishBindingSource.Current is Dish dish && dish is not null)
            {
                if (dishBindingSource.Count == 1)
                {
                    dishAddButton.Enabled = false;
                    dishComboBox.Enabled = false;
                }

                dishRemoveButton.Enabled = true;

                var menuDish = new MenuDish
                {
                    DishId = dish.Id,
                    Dish = dish,
                    Menu = _menu,
                    MenuId = _menu.Id,
                    Count = (int)countNumericUpDown.Value
                };

                _menu.MenuDishes.Add(menuDish);
                menuDishViewModelBindingSource.Add(_menuDishMapper
                    .Map<MenuDish, MenuDishViewModel>(menuDish));

                dishBindingSource.RemoveCurrent();
            }
        }

        private void dishRemoveButton_Click(object sender, EventArgs e)
        {
            if (menuDishViewModelBindingSource.Current is MenuDishViewModel menuDishVM && menuDishVM is not null)
            {
                if (menuDishViewModelBindingSource.Count == 1)
                {
                    dishRemoveButton.Enabled = false;
                }

                dishAddButton.Enabled = true;
                dishComboBox.Enabled = true;

                var menuDish = _menu.MenuDishes.Find(
                    menuDish => menuDish.DishId == menuDishVM.DishId);

                _menu.MenuDishes.Remove(menuDish);
                menuDishViewModelBindingSource.RemoveCurrent();
                dishBindingSource.Add(menuDish.Dish);
            }
        }
    }
}
