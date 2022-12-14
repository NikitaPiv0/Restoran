using Restoran.Models.Base;

namespace Restoran.ViewModels
{
    public class DishViewModel : ModelBase
    {
        public string Name { get; set; } = null!;

        public string ShortName { get; set; } = null!;

        public DateTime CreateAt { get; set; }

        public string CategoryName { get; set; } = null!;

        public string AuthorName { get; set; } = null!;
    }
}
