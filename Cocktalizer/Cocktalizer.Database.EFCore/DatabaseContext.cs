using Cocktalizer.Configuration;
using Cocktalizer.Models;
using Microsoft.EntityFrameworkCore;

namespace Cocktalizer.Database.EFCore
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Product> Products { get; set; }

		public DbSet<Cocktail> Cocktails { get; set; }

		public DbSet<Ingridient> Ingridients { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			Database.EnsureCreated();
			optionsBuilder.UseNpgsql(ApplicationConfiguration.GetConnectionString());
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cocktail>().HasIndex(x => x.Name);
			modelBuilder.Entity<Cocktail>().HasMany(x => x.Decorations).WithOne(x => x.Cocktail);
			base.OnModelCreating(modelBuilder);
		}
	}
}