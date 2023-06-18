using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Models;
using Anteiku.DAL.Abstractions;

namespace Anteiku.BLL.UseCases;

public class HistoryService : IHistoryService
{
    private readonly IPurshaseHistoryRepository _purshaseHistoryRepository;

    public HistoryService(IPurshaseHistoryRepository purshaseHistoryRepository)
    {
        _purshaseHistoryRepository = purshaseHistoryRepository;
    }

    public void CreatePurchaseHistoryItem(string title, double price, int count)
    {
        _purshaseHistoryRepository.Add(title, count, price);
    }

    public List<PurchaseHistoryOutput> GetAllHistory()
    {
        throw new NotImplementedException();
    }
}
