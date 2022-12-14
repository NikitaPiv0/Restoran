using Restoran.Models.Base;

namespace Restoran.Models
{
    public class Dish : ModelBase
    {
        public string Name { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public DateTime CreateAt { get; set; }

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public List<User> Authors { get; set; } = new List<User>();

        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<DishIngredient> DishIngredients { get; set; } = new List<DishIngredient>();

        public List<Menu> Menus { get; set; } = new List<Menu>();
        public List<MenuDish> MenuDishes { get; set; } = new List<MenuDish>();

        public List<Order> Orders { get; set; } = new List<Order>();
        public List<OrderDish> OrderDishes { get; set; } = new List<OrderDish>();
    }
}
