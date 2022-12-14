using Restoran.Models.Base;

namespace Restoran.Models
{
    public class Ingredient : ModelBase
    {
        public string Name { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public int Сalories { get; set; }

        public int Protein { get; set; }

        public int Carbohydrate { get; set; }

        public List<Dish> Dishes { get; set; } = new List<Dish>();
        public List<DishIngredient> DishIngredients { get; set; } = new List<DishIngredient>();
    }
}
