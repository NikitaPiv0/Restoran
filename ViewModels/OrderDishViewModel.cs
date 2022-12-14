namespace Restoran.ViewModels
{
    public class OrderDishViewModel
    {
        public Guid DishId { get; set; }

        public string DishName { get; set; } = null!;

        public int Count { get; set; }
    }
}
