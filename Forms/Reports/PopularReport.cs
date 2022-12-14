using Microsoft.EntityFrameworkCore;
using Restoran.Ef;
using Restoran.Mappings;
using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Forms.Reports
{
    public partial class PopularReport : Form
    {
        private List<Order> _orders;
        private readonly OrderDishMapper _orderDishMapper;

        public PopularReport()
        {
            InitializeComponent();

            _orderDishMapper = new OrderDishMapper();

            SetOrders(DateTime.Now.Date, DateTime.Now.Date.AddDays(1));
        }

        private void PopularReport_Load(object sender, EventArgs e)
        {
            SetOrderDishes();
        }

        private void stopDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (stopDateTimePicker.Value >= DateTime.Now.Date.AddDays(1))
            {
                stopDateTimePicker.Value = DateTime.Now;
            }

            SetOrders(startDateTimePicker.Value.Date, stopDateTimePicker.Value.Date);
        }

        private void stratDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value >= stopDateTimePicker.Value.Date.AddDays(1))
            {
                startDateTimePicker.Value = stopDateTimePicker.Value.AddDays(-1);
            }

            SetOrders(startDateTimePicker.Value.Date, stopDateTimePicker.Value.Date);
        }

        private void SetOrders(DateTime start, DateTime stop)
        {
            using (var dbContext = new AppDbContext())
            {
                _orders = dbContext.Orders.AsNoTracking()
                    .Include(order => order.OrderDishes)
                        .ThenInclude(orderDish => orderDish.Dish)
                    .Where(order => start <= order.CreateAt && order.CreateAt <= stop)
                    .ToList();
            }
        }

        private void SetOrderDishes()
        {
            var orderDishes = new List<OrderDish>();
            foreach (var order in _orders)
            {
                foreach (var orderDish in order.OrderDishes)
                {
                    if (!orderDishes.Exists(od => od.DishId == orderDish.DishId))
                    {
                        orderDishes.Add(orderDish);
                    }
                    else
                    {
                        var od = orderDishes.Find(od => od.DishId == orderDish.DishId);
                        od.Count += orderDish.Count;
                    }
                }
            }

            orderDishViewModelBindingSource.DataSource = _orderDishMapper
                .Map<OrderDish, OrderDishViewModel>(orderDishes).ToList();
        }
    }
}
