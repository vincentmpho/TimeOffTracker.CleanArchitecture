using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TimeOffTracker.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            return services;
        }
    }
}
