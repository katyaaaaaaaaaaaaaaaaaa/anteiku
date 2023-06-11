using Anteiku.BLL.Abstractions;
using Anteiku.BLL.Mappings;
using Anteiku.BLL.Models;
using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Enums;

namespace Anteiku.BLL.UseCases;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public List<UserOutput> GetAllUsers()
    {
        var users = _userRepository.GetAllUsers()
                                   .Select(x => x.ToUserOutput())
                                   .ToList();

        //..

        return users;
    }

    public UserOutput? GetById(int id)
    {
        var user = _userRepository.GetById(id).ToUserOutput();

        return user;
    }

    public UserOutput? GetByName(string name)
    {
        var user = _userRepository.GetByName(name).ToUserOutput();

        return user;
    }

    //public void AddUser(string name, DateTime birthDate, int positionId, string comment, string scheduleDays, string scheduleTime)
    //{
    //    if (string.IsNullOrWhiteSpace(name))
    //    {
    //        throw new ArgumentNullException(nameof(name), $"Имя пользователя не может быть пустым.");
    //    }

    //    _userRepository.AddUser(name, birthDate, positionId, comment, scheduleDays, scheduleTime);

    //    //отправить письмо на почту например
    //}

    public List<PositionOutput> GetAllPositions()
    {
        var positions = _userRepository.GetAllPositions().Select(x=>x.ToPositionOutput()).ToList();

        return positions;
    }

    public int GetUsersCount() => _userRepository.GetUsersCount();
    

    public void DelUser(int userId)
    {
        _userRepository.DelUser(userId);
    }

    public int GetRoleIdByRoleName(string roleName)
    {
        //TODO: добавить проверку на пустоту и null - roleName

        return _userRepository.GetRoleIdByRoleName(roleName);
    }

    public void UpdateUser(int id, string userName, DateTime birthday, int positionId, 
        string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime)
    {
        //TODO: добавить проверку на пустоту и null - roleName
        _userRepository.UpdateUser(id, userName, birthday, positionId, comment, scheduleDays, scheduleTime);
    }

    public void AddUser(string name, DateTime birthDate, int positionId, string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime)
    {
        //throw new NotImplementedException();
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name), $"Имя пользователя не может быть пустым.");
        }

        _userRepository.AddUser(name, birthDate, positionId, comment, scheduleDays, scheduleTime);

        //отправить письмо на почту например
    }
}