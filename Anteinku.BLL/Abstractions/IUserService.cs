using Anteiku.BLL.Models;
using Anteiku.DAL.Entities;

namespace Anteiku.BLL.Abstractions;

public interface IUserService
{
    void AddUser(string name, DateTime birthDate, int positionId);

    List<PositionOutput> GetAllPositions();

    List<UserOutput> GetAllUsers();

    UserOutput? GetById(int id);

    UserOutput? GetByName(string name);

    int GetUsersCount();

    void DelUser(int userId);

    int GetRoleIdByRoleName(string roleName);

    //TODO: добавить остальные поля
    void UpdateUser(int id, string userName);
}
