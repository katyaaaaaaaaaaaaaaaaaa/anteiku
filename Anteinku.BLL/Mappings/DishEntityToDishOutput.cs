using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;

namespace Anteiku.BLL.Mappings;

public static class DishEntityToDishOutput
{
    public static DishOutput? ToDishOutput(this DishEntity dishEntity)
    {
        if (dishEntity == null) 
            return null;

        DishOutput dishOutput = new()
        {
            Title = dishEntity.DishTitle,
            PriceInUsd = $"{dishEntity.DishPrice} $",
            Ingridients = dishEntity.Ingridients
                                .Select(createdDish => new IngridientOutput
                                {
                                    Title = createdDish.IngridientTitle
                                }).ToList()
        };

        return dishOutput;
    }
}
