using Cocktalizer.Models;
using Microsoft.EntityFrameworkCore;

namespace Cocktalizer.Database.EFCore
{
	public class DatabaseContext : DbContext
	{
		public DbSet<Product> Products { get; set; }
		
		public DbSet<Cocktail> Cocktails { get; set; }
		
		public DbSet<Ingridient> Ingridients { get; set; }
	}
}