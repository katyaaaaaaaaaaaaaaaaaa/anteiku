namespace Anteiku.BLL.Models;

public class IngridientOutput
{
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Количество при рассчете цены
    /// </summary>
    public string CountForPrice { get; set; }

    public string PriceInByn { get; set; } = string.Empty;

    /// <summary>
    /// Количество(штуки,граммы или мл) всего в наличии
    /// </summary>
    public string TotalCount { get; set; } = string.Empty;
    //TODO: homework override ToString()
}
