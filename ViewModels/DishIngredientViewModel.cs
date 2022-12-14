namespace Restoran.ViewModels
{
    public class DishIngredientViewModel
    {
        public Guid DishId { get; set; }

        public Guid IngredientId { get; set; }
        public string IngredientName { get; set; } = null!;

        public int Quntity { get; set; }

        public string UnitName { get; set; } = null!;
    }
}
