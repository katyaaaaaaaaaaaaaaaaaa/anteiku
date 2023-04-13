using Anteiku.BLL.Models;
using Anteiku.DAL.Repositories;

namespace Anteiku.BLL.UseCases;

//TODO: UseCases для Dish , напрмер создать, удалить, обновить, поиск по имени
public class DishService
{
    private readonly DishRepository _dishRepository;

    public DishService(DishRepository dishRepository)
    {
        _dishRepository = dishRepository;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="page">Номер страницы</param>
    /// <param name="pageSize">Количество элементов на странице</param>
    /// <returns></returns>
    public List<DishOutput> GetDishesWithPagination(int page, int pageSize)
    {
        //TODO: homework перенести пагинацию на БД
        var result = _dishRepository.GetAllDishes()
            .Skip((page-1) * pageSize)
            .Take(pageSize)
            .Select(x => new DishOutput
            {
                Title = x.DishTitle,
                PriceInUsd = $"{x.DishPrice} $",
                Ingridients = x.Ingridients
                                .Select(x => new IngridientsOutput 
                                {
                                    Title = x.IngridientTitle
                                }).ToList(),
            })
            .ToList();

        return result;
    }
}
