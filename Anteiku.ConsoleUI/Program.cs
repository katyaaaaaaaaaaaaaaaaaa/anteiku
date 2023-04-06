using Anteiku.DAL.Repositories;

namespace Anteiku.ConsoleUI;

internal class Program
{
    //HOMEWORK:
    //1. Почитать про репозиторий
    //2. Добавить сущость Блюдо в БД(создать ентити,
    //добавить в контекст,
    //создать репозиторий с набором метод для работы с этой сущностью)
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