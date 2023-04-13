using System.ComponentModel.DataAnnotations;

namespace Anteiku.DAL.Entities;

public class DishEntity
{
    [Key]
    public int DishId { get; set; }

    public string? DishTitle { get; set; }

    public double DishPrice { get; set; }

    public ICollection<IngridientEntity> Ingridients { get; set; } = new List<IngridientEntity>();
}
