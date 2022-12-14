using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Mappings
{
    public class OrderMapper : MapperBase
    {
        public OrderMapper()
        {
            CreateMap<Order, OrderViewModel>(order =>
                new OrderViewModel
                {
                    Id = order.Id,
                    CreateAt = order.CreateAt,
                    CompanyName = order.Menu.CopmanyName
                });
        }
    }
}
