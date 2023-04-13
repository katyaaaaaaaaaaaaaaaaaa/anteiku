namespace Anteiku.BLL.Models;

public class DishOutput
{
    public string Title { get; set; } = string.Empty;

    public string PriceInUsd { get; set; } = string.Empty;

    public List<IngridientsOutput> Ingridients { get; set; } = new List<IngridientsOutput>();

    //TODO: homework override ToString()
}
