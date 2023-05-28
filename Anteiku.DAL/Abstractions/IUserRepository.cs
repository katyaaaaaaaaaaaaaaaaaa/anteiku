using Anteiku.DAL.Entities;

namespace Anteiku.DAL.Abstractions;

public interface IUserRepository
{
    void AddUser(string name, DateTime birthDate, int positionId);

    List<PositionEntity> GetAllPositions();

    List<UserEntity> GetAllUsers();

    UserEntity? GetById(int id);

    UserEntity? GetByName(string name);

    int GetUsersCount();

    int GetRoleIdByRoleName(string roleName);

    void DelUser(int userId);

    //TODO: добавить остальные поля
    void UpdateUser(int id, string userName);
}