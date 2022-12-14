using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Mappings
{
    public class DishMapper : MapperBase
    {
        public DishMapper()
        {
            CreateMap<Dish, DishViewModel>(dish =>
                new DishViewModel
                {
                    Id = dish.Id,
                    Name = dish.Name,
                    ShortName = dish.ShortName,
                    CreateAt = dish.CreateAt,
                    CategoryName = dish.Category.Name,
                    AuthorName = dish.Authors.FirstOrDefault()?.FIO ?? string.Empty,
                });
        }
    }
}
