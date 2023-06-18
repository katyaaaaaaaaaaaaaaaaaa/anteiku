using Anteiku.DAL.Entities;

namespace Anteiku.DAL.Abstractions;

public interface IPurshaseHistoryRepository
{
    List<PurchaseHistoryItemEntity> GetAllHistory();

    void Add(string title, int count, double price);
}
