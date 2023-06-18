using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL.Repositories;

public class DishRepository : IDishRepository
{
    private AnteikuContext _db;

    public DishRepository(AnteikuContext context)
    {
        _db = context;
    }

    public List<DishEntity> GetAllDishes()
    {
        List<DishEntity> dishes = _db.Dishes.Include(x => x.Ingridients).ToList();

        return dishes;
    }

    public DishEntity? GetById(int id)
    {
        var findedDish = _db.Dishes.Include(x => x.Ingridients).FirstOrDefault(x => x.DishId == id);

        return findedDish;
    }

    public IngridientEntity? GetIngById(int id)
    {
        var findedIng = _db.Ingridients.FirstOrDefault(x => x.IngridientId == id );

        //if (findedIng is null)
        //{
        //    throw new ArgumentException($"Ingridient with id {findedIng} not found");
        //}

        return findedIng;
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

    public DishEntity CreateDish(string title, double price, List<int> ingridientsIds)
    {
        List<IngridientEntity> ingridients = new();

        foreach (var ingId in ingridientsIds)
        {
            var findedIng = _db.Ingridients.FirstOrDefault(x => x.IngridientId == ingId);

            if (findedIng is null)
            {
                throw new ArgumentException($"Ingridient with id {findedIng} not found");
            }

            ingridients.Add(findedIng);
        }

        var createdDish = new DishEntity
        {
            DishTitle = title,
            DishPrice = price,
            Ingridients = ingridients
        };

        _db.Dishes.Add(createdDish);

        _db.SaveChanges();

        return createdDish;
    }

    public DishEntity UpdateDish(int dishId, string title, double price, List<int> ingridientsIds = null)
    {
        var findedDish = GetById(dishId);

        if (findedDish is null)
        {
            throw new ArgumentException($"Dish with id {dishId} not found");
        }
        
        findedDish.DishTitle = title;
        findedDish.DishPrice = price;

        if (ingridientsIds is not null)
        {
            //TODO: удалить корректно связи, я посмотрю
            _db.RemoveRange(findedDish.Ingridients);

            List<IngridientEntity> ingridients = new();

            foreach (var ingId in ingridientsIds)
            {
                var findedIng = _db.Ingridients.FirstOrDefault(x => x.IngridientId == ingId);

                if (findedIng is null)
                {
                    throw new ArgumentException($"Ingridient with id {findedIng} not found");
                }

                ingridients.Add(findedIng);
            }
            
            findedDish.Ingridients = ingridients;
        }
        else
        {
            _db.Update(findedDish);
        }

        _db.SaveChanges();

        return findedDish;
    }

    public IngridientEntity UpdateIng(int id, int col)
    {
        var findedIng = GetIngById(id);


        if (findedIng is null)
        {
            throw new ArgumentException(); 
        }
        findedIng.TotalCount +=col;
        _db.Update(findedIng);

        _db.SaveChanges();

        return findedIng;
    }

    public void AddIng(string title, double price, int count, IngridientType type)
    {
        var createdIng = new IngridientEntity 
        {  
            IngridientTitle= title, 
            IngridientType = type, 
            PriceForDefaultCountInByn = price, 
            TotalCount = count
        };

        _db.Ingridients.Add(createdIng);

        _db.SaveChanges();
    }
}
