using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Mappings;
using Anteiku.BLL.Models;
using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;
using Anteiku.DAL.Repositories;
using System.Diagnostics;

namespace Anteiku.BLL.UseCases;


public class DishService : IDishService
{
    private readonly IDishRepository _dishRepository;

    public DishService(IDishRepository dishRepository)
    {
        _dishRepository = dishRepository;
    }

    public DishOutput CreateDish(string title, double price, List<int> ingridientsIds)
    {
        var createdDish = _dishRepository.CreateDish(title, price, ingridientsIds);

        return createdDish.ToDishOutput();
    }

    public void DeleteDish(int dishId)
    {
        throw new NotImplementedException();
    }

    public List<DishOutput> FindDishesByTitle(string title)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Метод вернёт список блюда с пагинацией.
    /// </summary>
    /// <param name="page">Номер страницы</param>
    /// <param name="pageSize">Количество элементов на странице</param>
    /// <returns></returns>
    public List<DishOutput> GetDishesWithPagination(int page, int pageSize)
    {
        //TODO: homework перенести пагинацию на БД
        var result = _dishRepository.GetAllDishes()
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .Select(x => x.ToDishOutput())
            .ToList();

        return result;
    }

    public DishOutput UpdateDish(int dishId, string title, double price, List<int> ingridientsIds = null)
    {
        var createdDish = _dishRepository.UpdateDish(dishId, title, price, ingridientsIds);

        return createdDish.ToDishOutput();
    }

    public List<IngridientOutput> GetAllIngridients()
    {
        var ingridients = _dishRepository.GetAllIngridients()
            .Select(x => x.ToIngridientOutput())
            .ToList();

        return ingridients;
    }

    public IngridientOutput? GetIngById(int id)
    {
        var findedIng = _dishRepository.GetIngById(id).ToIngridientOutput();
        return findedIng;
    }

    public IngridientOutput UpdateIng(int id, int col)
    {
        var createdIng = _dishRepository.UpdateIng(id, col).ToIngridientOutput();
        return createdIng;
    }

    public void AddNewIng(string title, double price, int countForPrice, int count, IngridientType type)
    {
        _dishRepository.AddIng(title,price,countForPrice, count,type);
    }


}
