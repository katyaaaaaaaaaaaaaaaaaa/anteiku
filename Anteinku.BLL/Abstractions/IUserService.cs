using Anteiku.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteiku.BLL.Abstractions
{
    public interface IUserService
    {
        void AddUser(string name, DateTime birthDate, int positionId);

        List<PositionEntity> GetAllPositions();

        List<UserEntity> GetAllUsers();

        UserEntity? GetById(int id);

        UserEntity? GetByName(string name);
        int GetUsersCount();
        void DelUsers(int userId);
    }
}
