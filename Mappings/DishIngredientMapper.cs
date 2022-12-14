using Restoran.Models;
using Restoran.ViewModels;

namespace Restoran.Mappings
{
    public class DishIngredientMapper : MapperBase
    {
        public DishIngredientMapper()
        {
            CreateMap<DishIngredient, DishIngredientViewModel>(dishIngredient =>
                new DishIngredientViewModel
                {
                    DishId = dishIngredient.DishId,
                    IngredientId = dishIngredient.IngredientId,
                    IngredientName = dishIngredient.Ingredient.Name,
                    Quntity = dishIngredient.Quntity,
                    UnitName = dishIngredient.UnitName
                });
        }
    }
}
