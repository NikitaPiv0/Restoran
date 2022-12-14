using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Forms
{
    public partial class OrderForm : Form
    {
        private readonly Order _order;
        private readonly List<Menu> _menus;
        private readonly OrderDishMapper _orderDishMapper;

        public OrderForm()
        {
            InitializeComponent();

            using (var dbContext = new AppDbContext())
            {
                _menus = dbContext.Menus.AsNoTracking()
                    .Include(menu => menu.Dishes)
                    .Where(menu =>
                        DateTime.Now.Date <= menu.Date &&
                        menu.Date <= DateTime.Now.Date.AddDays(1))
                    .ToList();

                _orderDishMapper = new OrderDishMapper();

                _order = new Order
                {
                    Id = Guid.NewGuid(),
                    CreateAt = DateTime.Now
                };
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = _order;
            menuBindingSource.DataSource = _menus;
        }

        private void addDishButton_Click(object sender, EventArgs e)
        {
            if (dishBindingSource.Current is Dish dish && dish is not null)
            {
                if (dishBindingSource.Count == 1)
                {
                    addDishButton.Enabled = false;
                    allDishComboBox.Enabled = false;
                }

                removeDishButton.Enabled = true;

                var orderDish = new OrderDish
                {
                    Dish = dish,
                    DishId = dish.Id,
                    Order = _order,
                    OrderId = _order.Id,
                    Count = (int)countDishNumericUpDown.Value
                };

                _order.OrderDishes.Add(orderDish);
                orderDishViewModelBindingSource.Add(_orderDishMapper
                    .Map<OrderDish, OrderDishViewModel>(orderDish));
                dishBindingSource.RemoveCurrent();
            }
        }

        private void removeDishButton_Click(object sender, EventArgs e)
        {
            if (orderDishViewModelBindingSource.Current is OrderDishViewModel orderDishVM && orderDishVM is not null)
            {
                if (orderDishViewModelBindingSource.Count == 1)
                {
                    removeDishButton.Enabled = false;
                }

                addDishButton.Enabled = true;
                allDishComboBox.Enabled = true;

                var orderDish = _order.OrderDishes.Find(
                    orderDish => orderDish.DishId == orderDishVM.DishId);

                _order.OrderDishes.Remove(orderDish);
                dishBindingSource.Add(orderDish.Dish);
                orderDishViewModelBindingSource.RemoveCurrent();
            }
        }

        private void menuBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (menuBindingSource.Current is Menu menu && menu is not null)
            {
                orderDishViewModelBindingSource.Clear();
                dishBindingSource.DataSource = new List<Dish>(menu.Dishes);
            }
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var dbContext = new AppDbContext())
            {
                var order = new Order
                {
                    Id = Guid.NewGuid(),
                    CreateAt = DateTime.Now,
                    MenuId = (Guid)conpanyComboBox.SelectedValue
                };

                order.Id = Guid.NewGuid();
                order.CreateAt = DateTime.Now;
                order.MenuId = (Guid)conpanyComboBox.SelectedValue;

                _order.OrderDishes.ForEach(orderDish =>
                {
                    order.OrderDishes.Add(new OrderDish
                    {
                        DishId = orderDish.DishId,
                        Count = orderDish.Count
                    });
                });

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
            }
        }
    }
}
