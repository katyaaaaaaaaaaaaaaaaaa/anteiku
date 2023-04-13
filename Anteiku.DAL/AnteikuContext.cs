using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL;

public class AnteikuContext : DbContext
{
    public AnteikuContext(DbContextOptions<AnteikuContext> options)
        : base(options)
    {
       // Database.EnsureDeleted();
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
                    UserName = "Katya",
                    BirthDate = DateTime.Now,
                    PositionId = 1,
                }
        );


        modelBuilder.Entity<IngridientEntity>().HasData(
               new IngridientEntity
               {
                   IngridientId = 1,
                   IngridientTitle = "pasta",
                   IngridientPrice = 5.3,
               },
               new IngridientEntity
               {
                   IngridientId = 2,
                   IngridientTitle = "Cheese",
                   IngridientPrice = 7.4,
               },
               new IngridientEntity
               {
                   IngridientId = 3,
                   IngridientTitle = "meet",
                   IngridientPrice = 10.5,
               }
       );        
    }
}

