using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace Restoran.Forms
{
    public partial class DishForm : Form
    {
        private readonly bool _isEdit;
        private readonly Dish _dish;
        private List<Category> _categories;
        private List<User> _authors;
        private List<Ingredient> _ingredient;
        private List<DishIngredientViewModel> _dishIngredientVMs;
        private DishIngredientMapper _dishIngredientMapper;

        public DishForm(Guid? dishId = null)
        {
            InitializeComponent();

            using (var dbContext = new AppDbContext())
            {
                _categories = dbContext.Categories.AsNoTracking().ToList();
                _authors = dbContext.Users.AsNoTracking()
                    .Include(user => user.Role)
                    .Where(user => user.Role.Name == "Повар")
                    .ToList();

                _ingredient = dbContext.Ingredients.AsNoTracking().ToList();

                _dishIngredientVMs = new List<DishIngredientViewModel>();
                _dishIngredientMapper = new DishIngredientMapper();

                if (dishId is null)
                {
                    _isEdit = false;
                    _dish = new Dish
                    {
                        Id = Guid.NewGuid(),
                        CategoryId = _categories.First().Id
                    };
                }
                else
                {
                    _isEdit = true;
                    _dish = dbContext.Dishes.AsNoTracking()
                        .Include(dish => dish.Ingredients)
                        .Include(dish => dish.Authors)
                        .Include(dish => dish.Category)
                        .Include(dish => dish.DishIngredients)
                            .ThenInclude(dishIngredient => dishIngredient.Ingredient)
                        .Single(dish => dish.Id == dishId);

                    _authors = _authors
                        .Where(a => !_dish.Authors.Exists(author => author.Id == a.Id))
                        .ToList();

                    _ingredient = _ingredient
                        .Where(ingredient => !_dish.Ingredients.Exists(i => i.Id == ingredient.Id))
                        .ToList();

                    _dish.DishIngredients.ForEach(dishIngredient =>
                    {
                        _dishIngredientVMs.Add(_dishIngredientMapper
                            .Map<DishIngredient, DishIngredientViewModel>(dishIngredient));
                    });

                    Text = "Изменение блюда";
                    acceptButton.Text = "Изменить";
                }
            }
        }

        private void DishForm_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = _categories;
            userBindingSource.DataSource = _authors;
            ingredientBindingSource.DataSource = _ingredient;

            if (userBindingSource.Count == 0)
            {
                authorAddButton.Enabled = false;
            }

            if (_dish.Authors.Count == 0)
            {
                authorRemoveButton.Enabled = false;
            }

            dishBindingSource.DataSource = _dish;
            categoryComboBox.SelectedValue = _dish.CategoryId;
            authorsBindingSource.DataSource = _dish.Authors;
            dishIngredientViewModelBindingSource.DataSource = _dishIngredientVMs;
        }

        private void DishForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nameTextBox.Text) ||
                    string.IsNullOrEmpty(shortNameTextBox.Text))
                {
                    MessageBox.Show("Все поля должнв быть заполнены", "Заполните поля",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    e.Cancel = true;
                    return;
                }

                using (var dbContext = new AppDbContext())
                {
                    _dish.Authors.ForEach(author =>
                    {
                        author.Role = null;
                    });

                    if (_isEdit)
                    {
                        var dishIngredients = _dish.DishIngredients.Select(di =>
                            new DishIngredient
                            {
                                IngredientId = di.IngredientId,
                                Quntity = di.Quntity,
                                UnitName = di.UnitName,
                            }).ToList();

                        var dish = dbContext.Dishes
                            .Include(dish => dish.DishIngredients)
                            .Include(dish => dish.Authors)
                            .Single(dish => dish.Id == _dish.Id);

                        dish.CategoryId = _dish.CategoryId;
                        dish.Name = _dish.Name;
                        dish.ShortName = _dish.ShortName;

                        dish.Authors.Clear();
                        var authors = dbContext.Users.ToList().Where(user =>
                            _dish.Authors.Exists(author => author.Id == user.Id));
                        dish.Authors.AddRange(authors);

                        dish.DishIngredients.Clear();
                        dish.DishIngredients.AddRange(dishIngredients);

                        dbContext.Update(dish);
                    }
                    else
                    {
                        var dishIngredients = _dish.DishIngredients.Select(di =>
                            new DishIngredient
                            {
                                IngredientId = di.IngredientId,
                                Quntity = di.Quntity,
                                UnitName = di.UnitName,
                            }).ToList();

                        var dish = new Dish
                        {
                            Name = _dish.Name,
                            ShortName = _dish.ShortName,
                            CreateAt = DateTime.Now,
                            CategoryId = _dish.CategoryId,
                            DishIngredients = dishIngredients
                        };

                        var authors = dbContext.Users.ToList().Where(user =>
                            _dish.Authors.Exists(author => author.Id == user.Id));

                        dish.Authors.AddRange(authors);

                        dbContext.Add(dish);

                    }


                    dbContext.SaveChanges();
                    dbContext.Dispose();
                }
            }
        }

        private void authorAddButton_Click(object sender, EventArgs e)
        {
            if (userBindingSource.Current is User author && author is not null)
            {
                if (userBindingSource.Count == 1)
                {
                    authorAddButton.Enabled = false;
                    authorComboBox.Enabled = false;
                }

                authorRemoveButton.Enabled = true;

                authorsBindingSource.Add(author);
                userBindingSource.RemoveCurrent();
            }
        }

        private void authorRemoveButton_Click(object sender, EventArgs e)
        {
            if (authorsBindingSource.Current is User author && author is not null)
            {
                if (authorsBindingSource.Count == 1)
                {
                    authorRemoveButton.Enabled = false;
                }

                authorAddButton.Enabled = true;
                authorComboBox.Enabled = true;

                userBindingSource.Add(author);
                authorsBindingSource.RemoveCurrent();
            }
        }

        private void ingredientAddButton_Click(object sender, EventArgs e)
        {
            if (ingredientBindingSource.Current is Ingredient ingredient && ingredient is not null)
            {
                if (ingredientBindingSource.Count == 1)
                {
                    ingredientAddButton.Enabled = false;
                    ingredientComboBox.Enabled = false;
                }

                ingredientRemoveButton.Enabled = true;

                var dishIngredient = new DishIngredient
                {
                    DishId = _dish.Id,
                    Dish = _dish,
                    IngredientId = ingredient.Id,
                    Ingredient = ingredient,
                    UnitName = ingridientUnitTextBox.Text.Trim(),
                    Quntity = (int)ingredientCountNumericUpDown.Value
                };

                _dish.DishIngredients.Add(dishIngredient);
                dishIngredientViewModelBindingSource.Add(_dishIngredientMapper
                    .Map<DishIngredient, DishIngredientViewModel>(dishIngredient));

                ingredientBindingSource.RemoveCurrent();
            }
        }

        private void ingredientRemoveButton_Click(object sender, EventArgs e)
        {
            if (dishIngredientViewModelBindingSource.Current 
                is DishIngredientViewModel dishIngredientViewModel &&
                    dishIngredientViewModel is not null)
            {
                if (dishIngredientViewModelBindingSource.Count == 1)
                {
                    ingredientRemoveButton.Enabled = false;
                }

                ingredientAddButton.Enabled = true;
                ingredientComboBox.Enabled = true;

                var dishIngredient = _dish.DishIngredients.Find(
                    di => di.IngredientId == dishIngredientViewModel.IngredientId);

                _dish.DishIngredients.Remove(dishIngredient);
                dishIngredientViewModelBindingSource.RemoveCurrent();
                ingredientBindingSource.Add(dishIngredient.Ingredient);
            }
        }
    }
}
