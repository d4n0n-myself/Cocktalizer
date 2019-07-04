using Cocktalizer.Configuration;
using Cocktalizer.Database.EFCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NLog;

namespace Cocktalizer.Web.Controllers
{
	public class BaseController : Controller
	{
		public IConfiguration Configuration => ApplicationConfiguration.Configuration;

		public IConfiguration DatabaseConfiguration => ApplicationConfiguration.Database;

		public ILogger Logger => ApplicationConfiguration.Logger;
	}
}