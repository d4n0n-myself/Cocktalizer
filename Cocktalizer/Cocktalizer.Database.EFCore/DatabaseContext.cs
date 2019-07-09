using Cocktalizer.Configuration;
using Cocktalizer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Cocktalizer.Database.EFCore
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		public DbSet<Cocktail> Cocktails { get; set; }
		public DbSet<Ingridient> Ingridients { get; set; }

		public DatabaseContext()
		{
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(ApplicationConfiguration.GetConnectionString())
				.ConfigureWarnings(warnings => warnings.Throw(CoreEventId.IncludeIgnoredWarning));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Cocktail>().HasIndex(x => x.Name);
		}
	}
}