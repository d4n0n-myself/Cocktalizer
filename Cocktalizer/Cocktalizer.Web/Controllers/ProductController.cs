using System;
using Cocktalizer.Database.EFCore;
using Cocktalizer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
		public IActionResult Add([FromBody] Product product)
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
		public IActionResult Delete([FromBody] Product product)
		{
			try
			{
				_context.Products.Remove(product);
				return Ok();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return InternalServerError();
			}
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_context.Products);
		}

		[HttpGet]
		public IActionResult GetProduct()
		{
			return NoContent();
		}

		[HttpPost]
		public IActionResult Update([FromBody] Product product)
		{
			return NoContent();
		}
	}
}