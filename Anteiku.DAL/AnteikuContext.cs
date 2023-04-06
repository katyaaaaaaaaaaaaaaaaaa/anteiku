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
}
