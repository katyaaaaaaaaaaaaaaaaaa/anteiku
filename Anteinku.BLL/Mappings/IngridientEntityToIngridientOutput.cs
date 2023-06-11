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
            Title = ingridientEntity.IngridientTitle,
            PriceInByn = ingridientEntity.IngridientPriceInByn.ToString() + " BYN",
            CountForPrice = ingridientEntity.CountForPrice.ToString() + mod,
            TotalCount = ingridientEntity.TotalCount.ToString() + mod
        };

        return ingridientOutput;
    }
}
