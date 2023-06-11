using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;

namespace Anteiku.BLL.Abstractions;

public interface IUserService
{
    void AddUser(string name, DateTime birthDate, int positionId, 
        string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime);

    List<PositionOutput> GetAllPositions();

    List<UserOutput> GetAllUsers();

    UserOutput? GetById(int id);

    UserOutput? GetByName(string name);

    int GetUsersCount();

    void DelUser(int userId);

    int GetRoleIdByRoleName(string roleName);

    //TODO: добавить остальные поля и position id
    void UpdateUser(int id, string userName, DateTime birthday,
                    int positionId, string comment,
                    ScheduleDays scheduleDays, ScheduleTime scheduleTime);
}
