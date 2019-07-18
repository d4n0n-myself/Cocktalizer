using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using NLog;
using NLog.Config;

namespace Cocktalizer.Configuration
{
	public static class ApplicationConfiguration
	{
		public static IConfiguration Configuration { get; } =
			new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();

		public static IConfiguration Database { get; } = Configuration.GetSection("Database");

		public static ILogger Logger
		{
			get
			{
				var nlogConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nlog.config");
				var configuration = new XmlLoggingConfiguration(nlogConfigPath);
				var loggerFactory = new LogFactory(configuration);
				var logger = loggerFactory.GetLogger("Default");
				return logger;
			}
		}

		public static string GetConnectionString() => Database["ConnectionString"];
	}
}