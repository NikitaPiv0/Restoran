using Restoran.Models.Base;

namespace Restoran.ViewModels
{
    public class MenuDishViewModel
    {
        public Guid DishId { get; set; }

        public string DishName { get; set; } = null!;

        public int Count { get; set; }
    }
}
