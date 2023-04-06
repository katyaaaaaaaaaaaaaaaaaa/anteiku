using Anteiku.DAL;
using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AnteikuDb;Trusted_Connection=True;";

            DbContextOptionsBuilder<AnteikuContext> optionsBuilder = new();

            optionsBuilder.UseSqlServer(connectionString);

            AnteikuContext db = new AnteikuContext(optionsBuilder.Options);

            db.Users.Add(new UserEntity
            {
                UserName= "Test",
                BirthDate= DateTime.Now,
                Position = "Admin"
            });

            db.SaveChanges();

            List<UserEntity> users = db.Users.ToList();

            foreach (UserEntity user in users)
            {
                Console.WriteLine(user.UserName);
            }
        }
    }
}

//1. Ставите sql server
//2. Ставите ss management studio
//3. Читаете про EntityFramework (metanit)
//4. Трехслойную архтиектуру
//5. Разбираетесь с доменом - думаете, какие сущности, как таблицы, какие отношения
//6. Добавить новые ентити в DAL->Entities и потренироваться их выбирать, обновлять, удалять, создавать.