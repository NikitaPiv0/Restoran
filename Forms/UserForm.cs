using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Models;

namespace Restoran.Forms
{
    public partial class UserForm : Form
    {
        private readonly bool _isEdit;
        private readonly User _user;
        private readonly List<Role> _roles;
        private readonly string _prevUserName;

        public UserForm(Guid? userId = null)
        {
            InitializeComponent();

            using (var dbContext = new AppDbContext())
            {
                _roles = dbContext.Roles.AsNoTracking().ToList();

                if (userId is null)
                {
                    _isEdit = false;
                    _user = new User
                    {
                        Id = Guid.NewGuid()
                    };
                }
                else
                {
                    _isEdit = true;
                    _user = dbContext.Users.AsNoTracking()
                        .Single(user => user.Id == userId);
                    _prevUserName = _user.UserName;

                    Text = "Изменение пользователя";
                    acceptButton.Text = "Изменить";
                }
            }            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = _user;
            roleBindingSource.DataSource = _roles;

            if (_isEdit)
            {
                roleComboBox.SelectedValue = _user.RoleId;
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                var userName = userNameTextBox.Text.Trim();
                if (string.IsNullOrEmpty(userName) ||
                    string.IsNullOrEmpty(passwordTextBox.Text) ||
                    string.IsNullOrEmpty(fioTextBox.Text))
                {
                    MessageBox.Show("Все поля должнв быть заполнены", "Заполните поля",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    e.Cancel = true;
                    return;
                }

                using (var dbContext = new AppDbContext())
                {
                    if (dbContext.Users.Any(user => user.UserName == userName) &&
                        (!_isEdit || _prevUserName != userName))
                    {
                        MessageBox.Show("Пользователь с таких логин уже занят", "Логин занят",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        e.Cancel = true;
                        return;
                    }

                    _user.RoleId = (Guid)roleComboBox.SelectedValue;
                    _user.BirthDay = birthDayDateTimePicker.Value;

                    if (_isEdit)
                    {
                        dbContext.Users.Update(_user);
                    }
                    else
                    {
                        dbContext.Users.Add(_user);
                    }

                    dbContext.SaveChanges();
                }
            }
        }
    }
}
