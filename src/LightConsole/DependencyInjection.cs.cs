using LightConsole.Extensions;
using LightConsole.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LightConsole;

public static class ServiceCollections
{
    /// <summary>
    ///     Register DI when run console.
    /// </summary>
    public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config)
    {
        // manual inject services here
        services.AddTransient<IDateTimeService, DateTimeService>();
        services.AddTransient<IConfigurationService, ConfigurationService>();

        // auto inject services
        services.AutoAddServices();

        return services;
    }
}
