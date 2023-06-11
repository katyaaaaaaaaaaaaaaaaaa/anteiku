using Anteiku.DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anteiku.DAL.Entities;

[Table("Ingridients")]
public class IngridientEntity
{
    [Key]    
    public int IngridientId { get; set; }

    public string IngridientTitle { get; set; }

    /// <summary>
    /// Тип ингридиента: штучный или по весу
    /// </summary>
    public IngridientType IngridientType { get; set; }

    /// <summary>
    /// Количество при рассчете цены
    /// </summary>
    public int CountForPrice  { get; set; }

    /// <summary>
    /// Цена за CountForPrice
    /// </summary>
    public double IngridientPriceInByn { get; set; }

    /// <summary>
    /// Количество(штуки,граммы или мл) всего в наличии
    /// </summary>
    public int TotalCount { get; set; }

    public ICollection<DishEntity> Dishes { get; set; } = new List<DishEntity>();
}
