using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AnteikuContext _db;

    public UserRepository(AnteikuContext context)
    {
        _db = context;
    }

    public List<UserEntity> GetAllUsers()
    {
        List<UserEntity> users = _db.Users.Include(x => x.Position).ToList();

        return users;
    }

    public UserEntity? GetById(int id)
    {
        var findedUser = _db.Users.FirstOrDefault(x => x.UserId == id);

        return findedUser;
    }

    public UserEntity? GetByName(string name)
    {
        var findedUser = _db.Users.FirstOrDefault(x => x.UserName == name);

        return findedUser;
    }

    public void AddUser(string name, DateTime birthDate, int positionId)
    {
        var createdUser = new UserEntity { UserName = name, BirthDate = birthDate, PositionId = positionId };

        _db.Users.Add(createdUser);

        _db.SaveChanges();
    }

    public List<PositionEntity> GetAllPositions()
    {
        return _db.Positions.ToList();
    }


    public int GetUsersCount()
    {
        int count = 0;
        for (int i = 0; i < _db.Users.ToList().Count; i++)
        {
            count ++;
        }
        return count;
    }

    public void DelUsers(int dishId)
    {
        if (_db.Users.ToList().Count > 0)
        {
            for (int i = 0; i < _db.Users.ToList().Count; i++)
            {
                UserEntity user = _db.Users.ToList()[i] as UserEntity;
                if (user != null)
                {
                    _db.Users.Remove(user);
                }
            }
        }
        _db.SaveChanges();
    }


}
