using MathexGaming.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace MathexGaming
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			IHost host = CreateHostBuilder(args).Build();

			await CreateDbIfNotExistsAsync(host);

			host.Run();
		}
		private static async Task CreateDbIfNotExistsAsync(IHost host)
		{
			using IServiceScope scope = host.Services.CreateScope();
			IServiceProvider services = scope.ServiceProvider;
			try
			{
				MathexGamingContext context = services.GetRequiredService<MathexGamingContext>();
				await DbInitializer.InitializeAsync(context);
			}
			catch (Exception ex)
			{
				ILogger<Program> logger = services.GetRequiredService<ILogger<Program>>();
				logger.LogError(ex, "An error occurred creating the DB.");
			}
		}		

		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>();
				});
	}
}
