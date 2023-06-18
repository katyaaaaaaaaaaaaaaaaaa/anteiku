using Anteiku.DAL.Entities;
using Anteiku.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL;

public class AnteikuContext : DbContext
{
    public AnteikuContext(DbContextOptions<AnteikuContext> options)
        : base(options)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<UserEntity> Users { get; set; }

    public DbSet<PositionEntity> Positions { get; set; }

    public DbSet<IngridientEntity> Ingridients { get; set; }

    public DbSet<DishEntity> Dishes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PositionEntity>().HasData(
                new PositionEntity
                {
                    PositionId = 1,
                    PositionTitle = "Administrator"
                },
                new PositionEntity
                {
                    PositionId = 2,
                    PositionTitle = "Cook"
                },
                new PositionEntity
                {
                    PositionId = 3,
                    PositionTitle = "Waiter"
                }
        );

        modelBuilder.Entity<UserEntity>().HasData(
                new UserEntity
                {
                    UserId = 1,
                    UserName = "Admin",
                    ScheduleDays = ScheduleDays.FIVEDAY,
                    ScheduleTime = ScheduleTime.START_8_00_END_17_00,
                    BirthDate = DateTime.Now,
                    PositionId = 1,
                }
        );


        modelBuilder.Entity<IngridientEntity>().HasData(
               new IngridientEntity
               {
                   IngridientId = 1,
                   IngridientTitle = "Куриные яйца",
                   IngridientType = IngridientType.COUNT,
                   CountForPrice = 10,
                   IngridientPriceInByn = 3,
               },
               new IngridientEntity
               {
                   IngridientId = 2,
                   IngridientTitle = "Сыр сливочный",
                   IngridientType = IngridientType.GRAMS,
                   CountForPrice = 100,
                   IngridientPriceInByn = 3.5,
               },
               new IngridientEntity
               {
                   IngridientId = 3,
                   IngridientTitle = "Куриное филе",
                   IngridientType = IngridientType.GRAMS,
                   CountForPrice = 1000,
                   IngridientPriceInByn = 12,
               },
               new IngridientEntity
               {
                   IngridientId = 4,
                   IngridientTitle = "Молоко",
                   IngridientType = IngridientType.MILLILITERS,
                   CountForPrice = 1000,
                   IngridientPriceInByn = 12,
               }
       );        
    }
}

