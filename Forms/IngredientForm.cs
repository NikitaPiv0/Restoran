using Restoran.Ef;
using Restoran.Models;

namespace Restoran.Forms
{
    public partial class IngredientForm : Form
    {
        private readonly bool _isEdit;
        private readonly Ingredient _ingredient;
        private readonly AppDbContext _dbContext;

        public IngredientForm(Ingredient? ingredient = null)
        {
            InitializeComponent();

            _dbContext = new AppDbContext();

            if (ingredient is null)
            {
                _isEdit = false;
                _ingredient = new Ingredient
                {
                    Id = Guid.NewGuid()
                };
            }
            else
            {
                _isEdit = true;
                _ingredient = new Ingredient
                {
                    Id = ingredient.Id,
                    Name = ingredient.Name,
                    ShortName = ingredient.ShortName,
                    Сalories = ingredient.Сalories,
                    Protein = ingredient.Protein,
                    Carbohydrate = ingredient.Carbohydrate
                };

                Text = "Изменение ингредиента";
                acceptButton.Text = "Изменить";
            }
        }

        private void IngredientForm_Load(object sender, EventArgs e)
        {
            ingredientBindingSource.DataSource = _ingredient;
        }

        private void IngredientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) ||
                string.IsNullOrEmpty(shortNameTextBox.Text))
            {
                MessageBox.Show("Все поля должнв быть заполнены", "Заполните поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true;
                return;
            }

            if (_isEdit)
            {
                _dbContext.Ingredients.Update(_ingredient);
            }
            else
            {
                _dbContext.Ingredients.Add(_ingredient);
            }

            _dbContext.SaveChanges();
            _dbContext.Dispose();
        }
    }
}
