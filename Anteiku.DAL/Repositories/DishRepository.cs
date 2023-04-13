using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL.Repositories;

public class DishRepository
{
    private AnteikuContext _db;

    public DishRepository(AnteikuContext context)
    {
        _db = context;
    }

    public List<DishEntity> GetAllDishes()
    {
        List<DishEntity> dishes = _db.Dishes./*Include(x => x.DishIngridients).*/ToList();

        return dishes;
    }

    public DishEntity? GetById(int id)
    {
        var findedDish = _db.Dishes.FirstOrDefault(x => x.DishId == id);

        return findedDish;
    }
    public DishEntity? GetByTitle(string name)
    {
        var findedDish = _db.Dishes.FirstOrDefault(x => x.DishTitle == name);

        return findedDish;
    }

    public List<IngridientEntity> GetAllIngridients()
    {
        return _db.Ingridients.ToList();
    }

    public void AddDishes(string title, double price, List<IngridientEntity> ingridients)
    {
        var createdDish = new DishEntity 
        { 
            DishTitle = title, 
            DishPrice = price, 
            Ingridients = ingridients
        };

        _db.Dishes.Add(createdDish);

        _db.SaveChanges();
    }
}
