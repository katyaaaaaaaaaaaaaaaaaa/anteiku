using Anteiku.BLL.Models;

namespace Anteiku.BLL.Abstractions;

public interface IHistoryService
{
    List<PurchaseHistoryOutput> GetAllHistory();

    void CreatePurchaseHistoryItem(string title, double price, int count);
}
