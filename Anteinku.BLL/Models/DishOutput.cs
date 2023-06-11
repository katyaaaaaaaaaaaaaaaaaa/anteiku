namespace Anteiku.BLL.Models;

public class DishOutput
{
    public string Title { get; set; } = string.Empty;

    public string PriceInUsd { get; set; } = string.Empty;

    public List<IngridientOutput> Ingridients { get; set; } = new List<IngridientOutput>();

    //TODO: homework override ToString()
}
