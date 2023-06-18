using Anteiku.DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anteiku.DAL.Entities;

[Table("Ingridients")]
public class IngridientEntity
{
    [Key]    
    public int IngridientId { get; set; }

    public string? IngridientTitle { get; set; }

    /// <summary>
    /// Тип ингридиента: штучный или по весу, или мл
    /// </summary>
    public IngridientType IngridientType { get; set; }

    /// <summary>
    /// Цена за 10 штук, 1000 грамм или 1000 мл
    /// </summary>
    public double PriceForDefaultCountInByn { get; set; }

    /// <summary>
    /// Количество (штуки,граммы или мл) всего в наличии
    /// </summary>
    public int TotalCount { get; set; }

    public ICollection<DishEntity> Dishes { get; set; } = new List<DishEntity>();
}
