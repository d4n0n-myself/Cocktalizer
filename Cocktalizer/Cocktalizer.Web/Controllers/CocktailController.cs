using Cocktalizer.Database.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cocktalizer.Web.Controllers
{
	public class CocktailController : BaseController
	{
		public CocktailController(DatabaseContext context)
		{
			_context = context;
		}

		private DatabaseContext _context;

		public IActionResult Get()
		{
			var result = _context.Cocktails
				.Include(c => c.Decorations)
				.Include(c => c.Components);
			return Ok(result);
		}
	}
}