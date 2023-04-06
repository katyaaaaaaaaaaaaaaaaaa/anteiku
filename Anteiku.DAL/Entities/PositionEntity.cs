using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anteiku.DAL.Entities;

[Table("Positions")]
public class PositionEntity
{
    [Key]
    public int PositionId { get; set; }

    public string PositionTitle { get; set; }
}
