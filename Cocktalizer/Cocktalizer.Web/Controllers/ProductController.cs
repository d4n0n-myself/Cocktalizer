using System;
using Cocktalizer.Database.EFCore;
using Cocktalizer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cocktalizer.Web.Controllers
{
	public class ProductController : BaseController
	{
		public ProductController(DatabaseContext context)
		{
			_context = context;
		}

		private DatabaseContext _context;
		
		[HttpPost]
		public IActionResult Add([FromBody]Product product)
		{
			try
			{
				_context.Products.Add(product);
				return Ok();
			}
			catch (Exception e)
			{
				Logger.Error(e, $"Failed to add Product entity with data : {product}");
				return new InternalErrorResult();
			}
		}

		[HttpPost]
		public IActionResult Delete()
		{
			return NoContent();
		}

		[HttpGet]
		public IActionResult Get()
		{
			return NoContent();
		}

		[HttpGet]
		public IActionResult GetProduct()
		{
			return NoContent();
		}

		[HttpPost]
		public IActionResult Update()
		{
			return NoContent();
		}
	}
}