using Restoran.Models.Base;

namespace Restoran.Models
{
    public class Order : ModelBase
    {
        public DateTime CreateAt { get; set; }

        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }

        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public List<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();
    }
}
