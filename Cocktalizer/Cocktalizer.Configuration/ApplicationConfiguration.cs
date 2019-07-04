using Microsoft.Extensions.Configuration;
using NLog;

namespace Cocktalizer.Configuration
{
	public static class ApplicationConfiguration
	{
		public static IConfiguration Configuration { get; } =
			new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();

		public static IConfiguration Database { get; } = Configuration.GetSection("Database");

		public static ILogger Logger => LogManager.GetLogger("Default");

		public static string GetConnectionString() => Database["ConnectionString"];
	}
}