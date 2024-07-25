using AppWithDbSettingsProvider.Config.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ApiWithSettingsDbProvider
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, builder) =>
                {
                    var configuration = builder.Build();
                    var settingsConnectionString = configuration.GetConnectionString("SettingsDb");

                    builder.AddSettingsDbProvider(options =>
                    {
                        options.UseSqlServer(settingsConnectionString);
                    });
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
