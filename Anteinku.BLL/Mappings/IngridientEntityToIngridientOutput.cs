using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;

namespace Anteiku.BLL.Mappings;

internal static class IngridientEntityToIngridientOutput
{
    public static IngridientOutput? ToIngridientOutput(this IngridientEntity ingridientEntity)
    {
        if (ingridientEntity == null)
            return null;

        string mod = string.Empty;

        switch (ingridientEntity.IngridientType)
        {
            case IngridientType.COUNT:
                mod = " шт.";
                break;
            case IngridientType.GRAMS:
                mod = " гр.";
                break;
            case IngridientType.MILLILITERS:
                mod = " мл.";
                break;
            default:
                break;
        }

        IngridientOutput ingridientOutput = new()
        {
            IngridientId = ingridientEntity.IngridientId,
            Title = ingridientEntity.IngridientTitle,
            PriceForDefaultCountInByn = ingridientEntity.PriceForDefaultCountInByn.ToString() + " BYN",
            TotalCount = ingridientEntity.TotalCount.ToString() + mod
        };

        return ingridientOutput;
    }
}
