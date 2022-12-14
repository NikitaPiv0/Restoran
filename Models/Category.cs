using Restoran.Models.Base;

namespace Restoran.Models
{
    public class Category : ModelBase
    {
        public string Name { get; set; } = null!;

        public virtual List<Dish> Dishes { get; set; } = new List<Dish>();
    }
}
