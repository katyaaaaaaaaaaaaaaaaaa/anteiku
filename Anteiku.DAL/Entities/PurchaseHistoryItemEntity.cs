using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anteiku.DAL.Entities;

[Table("PurchasesHistory")]
public class PurchaseHistoryItemEntity
{
    [Key]
    public int PurchaseId { get; set; }

    public string IngridientTitle { get; set; }

    public int Count { get; set; }

    public double Price { get; set; }

    public DateTime Date { get; set; }
}
