using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Entities;

namespace Anteiku.DAL.Repositories;

public class PurshaseHistoryRepository : IPurshaseHistoryRepository
{
    private AnteikuContext _db;

    public PurshaseHistoryRepository(AnteikuContext context)
    {
        _db = context;
    }

    public void Add(string title, int count, double price)
    {
        var createdIng = new PurchaseHistoryItemEntity
        {
            IngridientTitle = title,
            Date = DateTime.Now,
            Price = price,
            Count = count
        };

        _db.PurchasesHistory.Add(createdIng);

        _db.SaveChanges();
    }

    public List<PurchaseHistoryItemEntity> GetAllHistory()
    {
        return _db.PurchasesHistory.ToList();
    }
}
