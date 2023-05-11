using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anteiku.DAL.Entities;

/// <summary>
/// Сопоставляется с таблицей
/// </summary>
[Table("Users")]
public class UserEntity
{
    [Key]
    public int UserId { get; set; }

    [Required]
    [Column("Name")]
    public string? UserName { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    public int PositionId { get; set; }

    public PositionEntity? Position { get; set; }
}
