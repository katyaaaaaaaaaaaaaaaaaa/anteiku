using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anteiku.DAL.Entities;

[Table("Ingridients")]
public class IngridientEntity
{
    [Key]    
    public int IngridientId { get; set; }

    public string? IngridientTitle { get; set; }
    
    public double IngridientPrice { get; set; }

    public ICollection<DishEntity> Dishes { get; set; } = new List<DishEntity>();
}
