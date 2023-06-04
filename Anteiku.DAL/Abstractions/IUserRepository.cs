using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;

namespace Anteiku.DAL.Abstractions;

public interface IUserRepository
{
    void AddUser(string name, DateTime birthDate, int positionId, string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime);

    List<PositionEntity> GetAllPositions();

    List<UserEntity> GetAllUsers();

    UserEntity? GetById(int id);

    UserEntity? GetByName(string name);

    int GetUsersCount();

    int GetRoleIdByRoleName(string roleName);

    void DelUser(int userId);

    //TODO: добавить остальные поля
    void UpdateUser(int id, string userName, DateTime birthday, string positionTitle, string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime);
}