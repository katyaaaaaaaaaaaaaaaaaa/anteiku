using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL.Repositories;

public class UserRepository
{
	private AnteikuContext _db;

	public UserRepository()
	{
        //string connectionString = "Server=(localdb)\\mssqllocaldb;Database=AnteikuDb;Trusted_Connection=True;";

        DbContextOptionsBuilder<AnteikuContext> optionsBuilder = new();

        //optionsBuilder.UseSqlServer(connectionString);

        optionsBuilder.UseInMemoryDatabase("AnteikuDb");

        _db = new AnteikuContext(optionsBuilder.Options);
    }

	public List<UserEntity> GetAllUsers()
	{
        List<UserEntity> users = _db.Users.Include(x => x.Position).ToList();

		return users;
    }

	public UserEntity? GetById(int id)
	{
		var findedUser = _db.Users.FirstOrDefault(x=>x.UserId == id);

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
}
