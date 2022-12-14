using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Models;

namespace Restoran.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly bool _isEdit;
        private readonly Category _category;
        private readonly AppDbContext _dbContext;

        public CategoryForm(Guid? categoryId = null)
        {
            InitializeComponent();

            _dbContext = new AppDbContext();

            if (categoryId is null)
            {
                _isEdit = false;
                _category = new Category
                {
                    Id = Guid.NewGuid()
                };
            }
            else
            {
                _isEdit = true;
                _category = _dbContext.Categories
                    .Single(category => category.Id == categoryId);

                Text = "Изменение категории";
                acceptButton.Text = "Изменить";
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = _category;
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Все поля должнв быть заполнены", "Заполните поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true;
                return;
            }

            if (_isEdit)
            {
                _dbContext.Categories.Update(_category);
            }
            else
            {
                _dbContext.Categories.Add(_category);
            }

            _dbContext.SaveChanges();
            _dbContext.Dispose();
        }
    }
}
