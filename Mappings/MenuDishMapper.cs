using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Mappings
{
    public class MenuDishMapper : MapperBase
    {
        public MenuDishMapper()
        {
            CreateMap<MenuDish, MenuDishViewModel>(menu =>
                new MenuDishViewModel
                {
                    DishId = menu.DishId,
                    DishName = menu.Dish.Name,
                    Count = menu.Count
                });
        }
    }
}
