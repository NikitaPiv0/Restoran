using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Mappings
{
    public class OrderDishMapper : MapperBase
    {
        public OrderDishMapper()
        {
            CreateMap<OrderDish, OrderDishViewModel>(orderDish =>
                new OrderDishViewModel
                {
                    DishId = orderDish.DishId,
                    DishName = orderDish.Dish.Name,
                    Count = orderDish.Count
                });
        }
    }
}
