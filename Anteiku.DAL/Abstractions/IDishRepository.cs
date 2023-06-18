using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;

namespace Anteiku.DAL.Abstractions;

public interface IDishRepository
{
    DishEntity CreateDish(string title, double price, List<int> ingridientsIds);

    DishEntity UpdateDish(int dishId, string title, double price, List<int> ingridientsIds = null);

    List<DishEntity> GetAllDishes();

    List<IngridientEntity> GetAllIngridients();

    DishEntity? GetById(int id);

    DishEntity? GetByTitle(string name);

    public IngridientEntity? GetIngById(int id);

    IngridientEntity UpdateIng(int id, int col);

    void AddIng(string title, double price, int count, IngridientType type);
}