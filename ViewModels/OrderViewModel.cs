using Restoran.Models.Base;

namespace Restoran.ViewModels
{
    public class OrderViewModel : ModelBase
    {
        public DateTime CreateAt { get; set; }

        public string CompanyName { get; set; } = null!;
    }
}
