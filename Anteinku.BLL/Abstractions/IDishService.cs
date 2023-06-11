using Anteiku.BLL.Models;

namespace Anteiku.BLL.Abstractions;

public interface IDishService
{
    List<IngridientOutput> GetAllIngridients();

    List<DishOutput> GetDishesWithPagination(int page, int pageSize);

    DishOutput CreateDish(string title, double price, List<int> ingridientsIds);

    void DeleteDish(int dishId);

    DishOutput UpdateDish(int dishId, string title, double price, List<int> ingridientsIds = null);

    List<DishOutput> FindDishesByTitle(string title);
}