using Anteiku.DAL;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.ConsoleUI;

internal class Program
{
    //КОММЕНТАРИЙ ДЛЯ ГИТА
    static void Main(string[] args)
    {
        UserRepository userRepository = new UserRepository();

        userRepository.AddUser("Alex", DateTime.Now, 2);

        var users = userRepository.GetAllUsers();

        foreach (var user in users)
        {
            Console.WriteLine(user.UserName);
            Console.WriteLine(user.Position.PositionTitle);
        }

        var positions = userRepository.GetAllPositions();

        foreach (var pos in positions)
        {
            Console.WriteLine(pos.PositionTitle);
        }
    }
}