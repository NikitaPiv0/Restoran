using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Models;

namespace Restoran.Forms
{
    public partial class AuthForm : Form
    {
        private List<User> _users;

        public AuthForm()
        {
            InitializeComponent();

            using (var dbContext = new AppDbContext())
            {
                _users = dbContext.Users.AsNoTracking()
                    .Include(user => user.Role).ToList();
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var userName = userNameTextBox.Text.Trim();
            var password = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Все поля должнв быть заполнены", "Заполните поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _users.Find(user =>
                user.UserName == userName && user.Password == password);

            if (user is not null)
            {
                userNameTextBox.Clear();
                passwordTextBox.Clear();

                User.CurrentUser = user;

                using (var mainForm = new MainForm())
                {
                    Hide();

                    DialogResult result = mainForm.ShowDialog();
                    switch (result)
                    {
                        case DialogResult.Cancel:
                            Application.Exit();
                            break;

                        default:
                            using (var dbContext = new AppDbContext())
                            {
                                _users = dbContext.Users.AsNoTracking()
                                    .Include(user => user.Role).ToList();
                            }
                            Show();
                            return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден, возможно, логин и/или пароль указаны неверно",
                    "Пользователь не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
