using Anteiku.BLL.Abstractions;
using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anteiku.BLL.UseCases
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();

        }

        public UserEntity? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserEntity? GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public void AddUser(string name, DateTime birthDate, int positionId)
        {
            throw new NotImplementedException();
        }

        public List<PositionEntity> GetAllPositions()
        {
            throw new NotImplementedException();

        }


        public int GetUsersCount()
        {
            throw new NotImplementedException();

        }

        public void DelUsers(int dishId)
        {
            throw new NotImplementedException();
        }
       
    }

}
