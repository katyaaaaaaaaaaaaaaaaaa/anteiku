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

    void DelUser(int userId);
}