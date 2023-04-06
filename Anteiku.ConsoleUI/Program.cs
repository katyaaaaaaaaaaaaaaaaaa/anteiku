using Anteiku.DAL;
using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.ConsoleUI;

internal class Program
{
    //КОММЕНТАРИЙ ДЛЯ ГИТА
    static void Main(string[] args)
    {
        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AnteikuDb;Trusted_Connection=True;";

        DbContextOptionsBuilder<AnteikuContext> optionsBuilder = new();

        //optionsBuilder.UseSqlServer(connectionString);

        optionsBuilder.UseInMemoryDatabase("AnteikuDb");

        AnteikuContext db = new AnteikuContext(optionsBuilder.Options);              

        List<UserEntity> users = db.Users.Include(x=>x.Position).ToList();

        foreach (UserEntity user in users)
        {
            Console.WriteLine(user.UserName);
            Console.WriteLine(user.BirthDate);
            Console.WriteLine(user.Position.PositionTitle);
        }
    }
}