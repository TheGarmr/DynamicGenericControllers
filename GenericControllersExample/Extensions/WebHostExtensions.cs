using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace GenericControllersExample.Extensions
{
    public static class WebHostExtensions
    {
        public static IWebHostBuilder ConfigureAppConfigurations(this IWebHostBuilder builder)
        {
            return builder.ConfigureAppConfiguration((hostingContext, configBuilder) =>
            {
                var env = hostingContext.HostingEnvironment;

                configBuilder
                    .AddJsonFile("config/appsettings.json", true, true)
                    .AddJsonFile($"config/appsettings.{env.EnvironmentName}.json", true, true);
            });
        }
    }
}