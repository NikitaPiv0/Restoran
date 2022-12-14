using Restoran.Models.Base;

namespace Restoran.Models
{
    public class Menu : ModelBase
    {
        public string CopmanyName { get; set; } = null!;

        public DateTime Date { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public List<MenuDish> MenuDishes { get; set; } = new List<MenuDish>();
    }
}
