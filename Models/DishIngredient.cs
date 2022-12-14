namespace Restoran.Models
{
    public class DishIngredient
    {
        public Guid DishId { get; set; }
        public Dish Dish { get; set; }

        public Guid IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int Quntity { get; set; }

        public string UnitName { get; set; } = null!;
    }
}
