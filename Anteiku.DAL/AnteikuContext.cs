using Anteiku.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Anteiku.DAL;

public class AnteikuContext : DbContext
{
	public AnteikuContext(DbContextOptions<AnteikuContext> options) 
		: base(options)
	{
        Database.EnsureCreated();
    }

    public DbSet<UserEntity> Users { get; set; }

	public DbSet<PositionEntity> Positions { get; set; }

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
                    UserId= 1,
                    UserName = "Katya",
                    BirthDate = DateTime.Now,
                    PositionId = 1,
                }
        );
    }
}
