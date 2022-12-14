using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Forms;
using Restoran.Forms.Reports;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.Models.Base;
using Restoran.ViewModels;

namespace Restoran
{
    public partial class MainForm : Form
    {
        private readonly DishMapper _dishMapper;
        private readonly DishIngredientMapper _dishIngredientMapper;
        private readonly MenuDishMapper _menuDishMapper;
        private readonly OrderMapper _orderMapper;
        private readonly OrderDishMapper _orderDishMapper;
        private readonly UserMapper _userMapper;

        public MainForm()
        {
            InitializeComponent();

            _dishMapper = new DishMapper();
            _dishIngredientMapper = new DishIngredientMapper();
            _menuDishMapper = new MenuDishMapper();
            _orderMapper = new OrderMapper();
            _orderDishMapper = new OrderDishMapper();
            _userMapper = new UserMapper();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                categoryBindingSource.DataSource = dbContext.Categories.AsNoTracking().ToList();
                ingredientBindingSource.DataSource = dbContext.Ingredients.AsNoTracking().ToList();
                dishViewModelBindingSource.DataSource =
                    _dishMapper.Map<Dish, DishViewModel>(
                        dbContext.Dishes.AsNoTracking()
                            .Include(dish => dish.Category)
                            .Include(dish => dish.Authors)
                            .Include(dish => dish.DishIngredients)
                                .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                        .ToList();

                menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                    .Include(menu => menu.MenuDishes)
                        .ThenInclude(menuDish => menuDish.Dish)
                    .ToList();

                orderVeiwModelBindingSource.DataSource =
                    _orderMapper.Map<Order, OrderViewModel>(dbContext.Orders.AsNoTracking()
                        .Include(order => order.Menu))
                    .ToList();

                userViewModelBindingSource.DataSource = _userMapper.Map<User, UserViewModel>(
                    dbContext.Users.AsNoTracking().Include(user => user.Role)).ToList();

                if (!Role.IsAdmin(User.CurrentUser.Role))
                {
                    mainTabControl.TabPages.Remove(userTabPage);
                }

                if (Role.IsCook(User.CurrentUser.Role))
                {
                    mainTabControl.TabPages.Remove(orderTabPage);
                }

                if (Role.IsCashier(User.CurrentUser.Role))
                {
                    menuAddButton.Enabled = false;
                    menuEditButton.Enabled = false;
                    menuRemoveButton.Enabled = false;

                    dishAddButton.Enabled = false;
                    dishEditButton.Enabled = false;
                    dishRemoveButton.Enabled = false;

                    ingredintAddButton.Enabled = false;
                    ingredintEditButton.Enabled = false;
                    ingredintRemoveButton.Enabled = false;

                    categoryAddButton.Enabled = false;
                    categoryEditButton.Enabled = false;
                    categoryRemoveButton.Enabled = false;
                }
            }
        }

        private void categoryAddButton_Click(object sender, EventArgs e)
        {
            using (var categoryForm = new CategoryForm())
            {
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    using (var dbContext = new AppDbContext())
                    {
                        categoryBindingSource.DataSource =
                            dbContext.Categories.AsNoTracking().ToList();

                        dishViewModelBindingSource.DataSource =
                            _dishMapper.Map<Dish, DishViewModel>(
                                dbContext.Dishes.AsNoTracking()
                                    .Include(dish => dish.Category)
                                    .Include(dish => dish.Authors)
                                    .Include(dish => dish.DishIngredients)
                                        .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                                .ToList();
                    }
                }
            }
        }

        private void categoryEditButton_Click(object sender, EventArgs e)
        {
            if (categoryBindingSource.Current is Category category && category is not null)
            {
                using (var categoryForm = new CategoryForm(category.Id))
                {
                    if (categoryForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var dbContext = new AppDbContext())
                        {
                            categoryBindingSource.DataSource =
                                dbContext.Categories.AsNoTracking().ToList();

                            dishViewModelBindingSource.DataSource =
                                _dishMapper.Map<Dish, DishViewModel>(
                                    dbContext.Dishes.AsNoTracking()
                                        .Include(dish => dish.Category)
                                        .Include(dish => dish.Authors)
                                        .Include(dish => dish.DishIngredients)
                                            .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                                    .ToList();
                        }
                    }
                }
            }
        }

        private void categoryRemoveButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.RemoveEntity<Category>(categoryBindingSource))
            {
                using (var dbContext = new AppDbContext())
                {
                    dishViewModelBindingSource.DataSource =
                        _dishMapper.Map<Dish, DishViewModel>(
                            dbContext.Dishes.AsNoTracking()
                                .Include(dish => dish.Category)
                                .Include(dish => dish.Authors)
                                .Include(dish => dish.DishIngredients)
                                    .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                            .ToList();
                }
            }            
        }

        private void categoryFindButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                MainFormHelper.Search(dbContext.Categories, categoryBindingSource, categoryFindTextBox,
                (Category category) => category.Name.ToUpper().Contains(categoryFindTextBox.Text.Trim().ToUpper()));
            }
        }

        private void ingredintAddButton_Click(object sender, EventArgs e)
        {
            using (var ingredientForm = new IngredientForm())
            {
                if (ingredientForm.ShowDialog() == DialogResult.OK)
                {
                    using (var dbContext = new AppDbContext())
                    {
                        ingredientBindingSource.DataSource = dbContext.Ingredients.AsNoTracking().ToList();
                    }
                }
            }
        }

        private void ingredintEditButton_Click(object sender, EventArgs e)
        {
            if (ingredientBindingSource.Current is Ingredient ingredient && ingredient is not null)
            {
                using (var ingredientForm = new IngredientForm(ingredient))
                {
                    if (ingredientForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var dbContext = new AppDbContext())
                        {
                            ingredientBindingSource.DataSource = dbContext.Ingredients.AsNoTracking().ToList();
                         
                            if (dishViewModelBindingSource.Current is DishViewModel dishViewModel && dishViewModel is not null)
                            {
                                var dishIngredients = dbContext.DishIngredients.AsNoTracking()
                                .Include(dishIngredient => dishIngredient.Ingredient)
                                .Where(dishIngredient => dishIngredient.DishId == dishViewModel.Id)
                                .ToList();

                                dishIngredientViewModelBindingSource.DataSource = _dishIngredientMapper
                                    .Map<DishIngredient, DishIngredientViewModel>(dishIngredients).ToList();
                            }
                        }
                    }
                }
            }
        }

        private void ingredintRemoveButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.RemoveEntity<Ingredient>(ingredientBindingSource) &&
                dishViewModelBindingSource.Current is DishViewModel dishViewModel &&
                dishViewModel is not null)
            {
                using (var dbContext = new AppDbContext())
                {
                    var dishIngredients = dbContext.DishIngredients.AsNoTracking()
                        .Include(dishIngredient => dishIngredient.Ingredient)
                        .Where(dishIngredient => dishIngredient.DishId == dishViewModel.Id)
                        .ToList();

                    dishIngredientViewModelBindingSource.DataSource = _dishIngredientMapper
                        .Map<DishIngredient, DishIngredientViewModel>(dishIngredients).ToList();
                }
            }
        }

        private void ingredintFindButton_Click(object sender, EventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                MainFormHelper.Search(dbContext.Ingredients, ingredientBindingSource, ingredintFindTextBox,
                (Ingredient ingredient) =>
                    ingredient.Name.ToUpper().Contains(ingredintFindTextBox.Text.Trim().ToUpper()) ||
                    ingredient.ShortName.ToUpper().Contains(ingredintFindTextBox.Text.Trim().ToUpper()));
            }
        }

        private void dishAddButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.CollectionIsEmpty(categoryBindingSource, "Категории") ||
                MainFormHelper.CollectionIsEmpty(ingredientBindingSource, "Ингредиенты"))
            {
                return;
            }

            using (var dbContext = new AppDbContext())
            {
                var authorRole = dbContext.Roles.AsNoTracking()
                    .Include(role => role.Users)
                    .Single(role => role.Name == Role.Cook);

                if (authorRole.Users.Count == 0)
                {
                    MessageBox.Show("В таблице \"Авторы\" отстуствуют записи. Добавьте хотя бы одну",
                        "Записи отстуствуют", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            using (var dishForm = new DishForm())
            {
                if (dishForm.ShowDialog() == DialogResult.OK)
                {
                    using (var dbContext = new AppDbContext())
                    {
                        dishViewModelBindingSource.DataSource =
                        _dishMapper.Map<Dish, DishViewModel>(
                            dbContext.Dishes.AsNoTracking()
                                .Include(dish => dish.Category)
                                .Include(dish => dish.Authors))
                            .ToList();
                    }
                }
            }
        }

        private void dishEditButton_Click(object sender, EventArgs e)
        {
            if (dishViewModelBindingSource.Current is DishViewModel dishVM && dishVM is not null)
            {
                using (var dishForm = new DishForm(dishVM.Id))
                {
                    if (dishForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var dbContext = new AppDbContext())
                        {
                            dishViewModelBindingSource.DataSource =
                                _dishMapper.Map<Dish, DishViewModel>(
                                    dbContext.Dishes.AsNoTracking()
                                        .Include(dish => dish.Category)
                                        .Include(dish => dish.Authors)
                                        .Include(dish => dish.DishIngredients)
                                            .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                                    .ToList();

                            menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                                .Include(menu => menu.MenuDishes)
                                    .ThenInclude(menuDish => menuDish.Dish)
                                .ToList();
                            
                            if (orderVeiwModelBindingSource.Current is OrderViewModel orderVM && orderVM is not null)
                            {
                                orderDishViewModelBindingSource.DataSource = _orderDishMapper
                                .Map<OrderDish, OrderDishViewModel>(
                                    dbContext.OrderDishes.AsNoTracking()
                                    .Where(orderDish => orderDish.OrderId == orderVM.Id)
                                    .Include(orderDish => orderDish.Dish))
                                .ToList();
                            }
                        }
                    }
                }
            }
        }

        private void dishRemoveButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.RemoveEntityByViewModel<Dish, DishViewModel>(dishViewModelBindingSource))
            {
                using (var dbContext = new AppDbContext())
                {
                    menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                        .Include(menu => menu.MenuDishes)
                            .ThenInclude(menuDish => menuDish.Dish)
                        .ToList();
                    
                    if (orderVeiwModelBindingSource.Current is OrderViewModel orderVM && orderVM is not null)
                    {
                        orderDishViewModelBindingSource.DataSource = _orderDishMapper
                        .Map<OrderDish, OrderDishViewModel>(
                            dbContext.OrderDishes.AsNoTracking()
                                .Where(orderDish => orderDish.OrderId == orderVM.Id)
                                .Include(orderDish => orderDish.Dish))
                            .ToList();
                    }
                }
            }
        }

        private void dishFindButton_Click(object sender, EventArgs e)
        {
            var search = dishFindTextBox.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(search))
            {
                using (var dbContext = new AppDbContext())
                {
                    dishViewModelBindingSource.DataSource =
                    _dishMapper.Map<Dish, DishViewModel>(
                        dbContext.Dishes.AsNoTracking()
                            .Include(dish => dish.Category)
                            .Include(dish => dish.Authors)
                            .Include(dish => dish.DishIngredients)
                                .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                        .ToList();
                }
                return;
            }


            using (var dbContext = new AppDbContext())
            {
                dishViewModelBindingSource.DataSource =
                _dishMapper.Map<Dish, DishViewModel>(
                    dbContext.Dishes.AsNoTracking()
                        .Include(dish => dish.Category)
                        .Include(dish => dish.Authors)
                        .Include(dish => dish.DishIngredients)
                            .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                        .Where(dish =>
                            dish.Name.ToUpper().Contains(search) ||
                            dish.ShortName.ToUpper().Contains(search))
                    .ToList();
            }
        }

        private void dishViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (dishViewModelBindingSource.Current is DishViewModel dishViewModel && dishViewModel is not null)
            {
                using (var dbContext = new AppDbContext())
                {
                    var dishIngredients = dbContext.DishIngredients.AsNoTracking()
                        .Include(dishIngredient => dishIngredient.Ingredient)
                        .Where(dishIngredient => dishIngredient.DishId == dishViewModel.Id)
                        .ToList();

                    dishIngredientViewModelBindingSource.DataSource = _dishIngredientMapper
                        .Map<DishIngredient, DishIngredientViewModel>(dishIngredients).ToList();
                }
            }
            else
            {
                dishIngredientViewModelBindingSource.DataSource = new List<DishIngredientViewModel>();
            }
        }

        private void menuAddButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.CollectionIsEmpty(dishViewModelBindingSource, "Блюда"))
            {
                return;
            }

            using (var menuForm = new MenuForm())
            {
                if (menuForm.ShowDialog() == DialogResult.OK)
                {
                    using (var dbContext = new AppDbContext())
                    {
                        menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                            .Include(menu => menu.MenuDishes)
                                .ThenInclude(menuDish => menuDish.Dish)
                            .ToList();
                    }
                }
            }
        }

        private void menuEditButton_Click(object sender, EventArgs e)
        {
            if (menuBindingSource.Current is Menu menu && menu is not null)
            {
                using (var menuForm = new MenuForm(menu.Id))
                {
                    if (menuForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var dbContext = new AppDbContext())
                        {
                            menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                                .Include(menu => menu.MenuDishes)
                                    .ThenInclude(menuDish => menuDish.Dish)
                                .ToList();

                            orderVeiwModelBindingSource.DataSource =
                                _orderMapper.Map<Order, OrderViewModel>(dbContext.Orders.AsNoTracking()
                                    .Include(order => order.Menu))
                                .ToList();
                        }
                    }
                }
            }            
        }

        private void menuRemoveButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.RemoveEntity<Menu>(menuBindingSource))
            {
                using (var dbContext = new AppDbContext())
                {
                    orderVeiwModelBindingSource.DataSource =
                        _orderMapper.Map<Order, OrderViewModel>(dbContext.Orders.AsNoTracking()
                            .Include(order => order.Menu))
                        .ToList();
                }
            }
        }

        private void menuFindButton_Click(object sender, EventArgs e)
        {
            var search = menuFindTextBox.Text.Trim().ToUpper();
            var searchDate = menuDateTimePicker.Value;

            if (string.IsNullOrEmpty(search))
            {
                using (var dbContext = new AppDbContext())
                {
                    menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                    .Include(menu => menu.MenuDishes)
                        .ThenInclude(menuDish => menuDish.Dish)
                    .Where(menu =>
                        searchDate.Date <= menu.Date &&
                        menu.Date <= searchDate.Date.AddDays(1))
                    .ToList();
                }
                return;
            }

            using (var dbContext = new AppDbContext())
            {
                menuBindingSource.DataSource = dbContext.Menus.AsNoTracking()
                    .Include(menu => menu.MenuDishes)
                        .ThenInclude(menuDish => menuDish.Dish)
                    .Where(menu =>
                        menu.CopmanyName.ToUpper().Contains(search) &&
                        searchDate.Date <= menu.Date &&
                        menu.Date <= searchDate.Date.AddDays(1))
                    .ToList();
            }
        }

        private void menuBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (menuBindingSource.Current is Menu menu && menu is not null)
            {
                menuDishViewModelBindingSource.DataSource = _menuDishMapper
                    .Map<MenuDish, MenuDishViewModel>(menu.MenuDishes).ToList();
            }
            else
            {
                menuDishViewModelBindingSource.DataSource = new List<MenuDishViewModel>();
            }
        }

        private void orderAddButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.CollectionIsEmpty(menuBindingSource, "Меню"))
            {
                return;
            }

            using (var orderForm = new OrderForm())
            {
                if (orderForm.ShowDialog() == DialogResult.OK)
                {
                    using (var dbContext = new AppDbContext())
                    {
                        orderVeiwModelBindingSource.DataSource = 
                            _orderMapper.Map<Order, OrderViewModel>(dbContext.Orders.AsNoTracking()
                                .Include(order => order.Menu))
                            .ToList();
                    }
                }
            }
        }

        private void orderRemoveButton_Click(object sender, EventArgs e)
        {
            MainFormHelper.RemoveEntityByViewModel<Order, OrderViewModel>(orderVeiwModelBindingSource);
        }

        private void orderVeiwModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (orderVeiwModelBindingSource.Current is OrderViewModel orderVM && orderVM is not null)
            {
                using (var dbContext = new AppDbContext())
                {
                    orderDishViewModelBindingSource.DataSource = _orderDishMapper
                        .Map<OrderDish, OrderDishViewModel>(
                            dbContext.OrderDishes.AsNoTracking()
                                .Where(orderDish => orderDish.OrderId == orderVM.Id)
                                .Include(orderDish => orderDish.Dish))
                            .ToList();
                }
            }
            else
            {
                orderDishViewModelBindingSource.DataSource = new List<OrderDishViewModel>();
            }
        }

        private void userAddButton_Click(object sender, EventArgs e)
        {
            using (var addUserForm = new UserForm())
            {
                if (addUserForm.ShowDialog() == DialogResult.OK)
                {
                    using (var dbContext = new AppDbContext())
                    {
                        userViewModelBindingSource.DataSource = _userMapper.Map<User, UserViewModel>(
                            dbContext.Users.AsNoTracking().Include(user => user.Role)).ToList();
                    }
                }
            }
        }

        private void userEditButton_Click(object sender, EventArgs e)
        {
            if (userViewModelBindingSource.Current is UserViewModel userVM && userVM is not null)
            {
                using (var addUserForm = new UserForm(userVM.Id))
                {
                    if (addUserForm.ShowDialog() == DialogResult.OK)
                    {
                        using (var dbContext = new AppDbContext())
                        {
                            userViewModelBindingSource.DataSource = _userMapper.Map<User, UserViewModel>(
                                dbContext.Users.AsNoTracking().Include(user => user.Role)).ToList();

                            dishViewModelBindingSource.DataSource =
                               _dishMapper.Map<Dish, DishViewModel>(
                                    dbContext.Dishes.AsNoTracking()
                                        .Include(dish => dish.Category)
                                        .Include(dish => dish.Authors)
                                        .Include(dish => dish.DishIngredients)
                                            .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                                    .ToList();
                        }
                    }
                }
            }
        }

        private void userRemoveButton_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.RemoveEntityByViewModel<User, UserViewModel>(userViewModelBindingSource))
            {
                using (var dbContext = new AppDbContext())
                {
                    dishViewModelBindingSource.DataSource =
                       _dishMapper.Map<Dish, DishViewModel>(
                            dbContext.Dishes.AsNoTracking()
                                .Include(dish => dish.Category)
                                .Include(dish => dish.Authors)
                                .Include(dish => dish.DishIngredients)
                                    .ThenInclude(dishIngredient => dishIngredient.Ingredient))
                            .ToList();
                }                
            }
        }

        private void userFindButton_Click(object sender, EventArgs e)
        {
            var search = userFindTextBox.Text.Trim().ToUpper();

            if (string.IsNullOrEmpty(search))
            {
                using (var dbContext = new AppDbContext())
                {
                    userViewModelBindingSource.DataSource =
                        _userMapper.Map<User, UserViewModel>(
                            dbContext.Users.AsNoTracking()
                                .Include(user => user.Role)).ToList();
                }
                return;
            }

            using (var dbContext = new AppDbContext())
            {
                userViewModelBindingSource.DataSource =
                    _userMapper.Map<User, UserViewModel>(
                        dbContext.Users.AsNoTracking()
                            .Where(user => user.FIO.ToUpper().Contains(search) ||
                                user.UserName.ToUpper().Contains(search))
                            .Include(user => user.Role)).ToList();
            }
        }

        private void списокБлюдToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.CollectionIsEmpty(menuBindingSource, "Меню"))
            {
                return;
            }

            new MenuReports().ShowDialog();
        }

        private void списокИнгридиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.CollectionIsEmpty(menuBindingSource, "Меню"))
            {
                return;
            }

            new ImgredientReport().ShowDialog();
        }

        private void популярныеБлюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainFormHelper.CollectionIsEmpty(orderVeiwModelBindingSource, "Заказы"))
            {
                return;
            }

            new PopularReport().ShowDialog();
        }


        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.TryAgain;
            Close();
        }
    }
}

public static class MainFormHelper
{
    public delegate bool SearchFunc<TModel>(TModel model, string search);

    public static void Search<TModel>(DbSet<TModel> models, BindingSource bindingSource,
        TextBox searchTextBox, Func<TModel, bool> predicate)
            where TModel : class
    {
        if (string.IsNullOrEmpty(searchTextBox.Text.Trim().ToUpper()))
        {
            bindingSource.DataSource = models.AsNoTracking().ToList();
            return;
        }

        bindingSource.DataSource = models.AsNoTracking().Where(predicate).ToList();
    }

    public static bool RemoveEntity<TModel>(BindingSource bindingSource)
            where TModel : class
    {
        if (bindingSource.Current is TModel model && model is not null &&
            MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            using (var dbContext = new AppDbContext())
            {
                dbContext.Remove(model);
                dbContext.SaveChanges();

                bindingSource.RemoveCurrent();
            }

            return true;
        }

        return false;
    }

    public static bool RemoveEntityByViewModel<TModel, TViewModel>(
        BindingSource bindingSource)
            where TModel : ModelBase
            where TViewModel : ModelBase
    {
        if (bindingSource.Current is TViewModel modelVM && modelVM is not null &&
            MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            using (var dbContext = new AppDbContext())
            {
                TModel model = dbContext.Find<TModel>(modelVM.Id)!;

                dbContext.Remove(model);
                dbContext.SaveChanges();

                bindingSource.RemoveCurrent();
            }

            return true;
        }

        return false;
    }

    public static bool CollectionIsEmpty(BindingSource bindingSource, string tableName)
    {
        if (bindingSource.Count == 0)
        {
            MessageBox.Show($"В таблице \"{tableName}\" отстуствуют записи. Добавьте хотя бы одну",
                "Записи отстуствуют", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            return true;
        }

        return false;
    }
}
