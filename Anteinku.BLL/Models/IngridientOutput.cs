namespace Anteiku.BLL.Models;

public class IngridientOutput
{
    public int IngridientId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string PriceForDefaultCountInByn { get; set; } = string.Empty;

    /// <summary>
    /// Количество(штуки,граммы или мл) всего в наличии
    /// </summary>
    public string TotalCount { get; set; } = string.Empty;
    //TODO: homework override ToString()
}
