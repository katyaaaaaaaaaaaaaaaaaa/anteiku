using Anteiku.BLL.UseCases;
using Anteiku.DAL;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.ConsoleUI;

internal class Program
{
    static void Main(string[] args)
    {
        #region CONTEXT

        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AnteikuDb;Trusted_Connection=True;";

        DbContextOptionsBuilder<AnteikuContext> optionsBuilder = new();

        optionsBuilder.UseSqlServer(connectionString);

        //optionsBuilder.UseInMemoryDatabase("AnteikuDb");

        AnteikuContext _db = new AnteikuContext(optionsBuilder.Options);

        #endregion

        #region REPOSITORIES
        DishRepository dishRepository = new DishRepository(_db);
        #endregion

        #region BLL_SERVICES

        DishService dishService = new DishService(dishRepository);

        #endregion

        var dishes = dishService.GetDishesWithPagination(1, 10);

        foreach (var dish in dishes)
        {
            Console.WriteLine($"{dish.Title} {dish.PriceInUsd}");
        }
    }
}