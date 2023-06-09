﻿using Anteiku.DAL.Abstractions;
using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;
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
        var findedUser = _db.Users.Include(x => x.Position).FirstOrDefault(x => x.UserId == id);

        return findedUser;
    }

    public UserEntity? GetByName(string name)
    {
        var findedUser = _db.Users.Include(x=>x.Position).FirstOrDefault(x => x.UserName == name);

        return findedUser;
    }

    public void AddUser(string name, DateTime birthDate, int positionId, string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime)
    {
        var createdUser = new UserEntity { UserName = name, BirthDate = birthDate, PositionId = positionId, Comment = comment, ScheduleDays = scheduleDays, ScheduleTime = scheduleTime };

        _db.Users.Add(createdUser);

        _db.SaveChanges();
    }

    public List<PositionEntity> GetAllPositions()
    {
        return _db.Positions.ToList();
    }

    public int GetUsersCount()
    {
        return _db.Users.Count();
    }

    public void DelUser(int userId)
    {
        var user = GetById(userId);

        //TODO: бросать исключение если юзер не найден

        if (user is not null)
        {
            _db.Users.Remove(user);

            _db.SaveChanges();
        }        
    }

    public int GetRoleIdByRoleName(string roleName)
    {
        var position = _db.Positions.FirstOrDefault(x => x.PositionTitle == roleName);

        if (position is null)
        {
            //TODO: бросать исключение если должность не найдена
        }

        return position.PositionId;
    }

    public void UpdateUser(int id, string userName, DateTime birthday, int positionId, 
        string comment, ScheduleDays scheduleDays, ScheduleTime scheduleTime)
    {
        var user = GetById(id);

        if (user is null)
        {
            throw new ArgumentException();
        }

        user.UserName = userName;
        user.PositionId = positionId;
        user.BirthDate = birthday;
        user.ScheduleDays = scheduleDays;
        user.ScheduleTime = scheduleTime;
        user.Comment = comment;

        _db.Update(user);

        _db.SaveChanges();
    }
}
