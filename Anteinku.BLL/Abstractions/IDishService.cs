using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;

namespace Anteiku.BLL.Abstractions;

public interface IDishService
{
    List<IngridientOutput> GetAllIngridients();

    List<DishOutput> GetDishesWithPagination(int page, int pageSize);

    DishOutput CreateDish(string title, double price, List<int> ingridientsIds);

    void DeleteDish(int dishId);

    DishOutput UpdateDish(int dishId, string title, double price, List<int> ingridientsIds = null);

    List<DishOutput> FindDishesByTitle(string title);

    IngridientOutput? GetIngById(int id);

    IngridientOutput UpdateIng(int id, int col);

    void AddNewIng(string title, double price, int count, IngridientType type);
}
    