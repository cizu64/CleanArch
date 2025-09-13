using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Persistence;
using CleanArch.Infrastructure.Services.Logs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure.ServiceRegistrations;
public static class Registrations
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<MyContext>(options =>
            options.UseNpgsql(
                configuration["ConnectionString"], opt => opt.EnableRetryOnFailure(5, TimeSpan.FromSeconds(30), errorCodesToAdd: null)
        ));

        services.AddSingleton<ILog, Logger>();

        // services.AddOptions<JwtOptions>()
        //     .Bind(configuration.GetSection("JWT"));

        return services;
    }
}