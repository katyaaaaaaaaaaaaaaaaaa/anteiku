using Anteiku.DAL.Entities;

namespace Anteiku.DAL.Abstractions;

public interface IDishRepository
{
    DishEntity CreateDish(string title, double price, List<int> ingridientsIds);

    DishEntity UpdateDish(int dishId, string title, double price, List<int> ingridientsIds = null);

    List<DishEntity> GetAllDishes();

    List<IngridientEntity> GetAllIngridients();

    DishEntity? GetById(int id);

    DishEntity? GetByTitle(string name);
}