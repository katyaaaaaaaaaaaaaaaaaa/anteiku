using Anteiku.BLL.Abstractions;
using Anteiku.BLL.UseCases;
using Anteiku.DAL;
using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.WinForms
{

    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            #region CONTEXT

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AnteikuDb;Trusted_Connection=True;";

            DbContextOptionsBuilder<AnteikuContext> optionsBuilder = new();

            optionsBuilder.UseSqlServer(connectionString);

            //optionsBuilder.UseInMemoryDatabase("AnteikuDb");

            AnteikuContext _db = new AnteikuContext(optionsBuilder.Options);
  
            #endregion

            #region REPOSITORIES

            IDishRepository dishRepository = new DishRepository(_db);

            UserRepository userRepository = new UserRepository(_db);

            #endregion

            #region BLL_SERVICES

            IDishService dishService = new DishService(dishRepository);

            UserService userService = new UserService(userRepository);

            #endregion

            Application.Run(new LoginForm(userService, dishService));
        }
    }
}