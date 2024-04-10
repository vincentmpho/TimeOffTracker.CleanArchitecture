using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeOffTracker.Application.Contracts.Email;
using TimeOffTracker.Application.Models.Email;
using TimeOffTracker.Infrastructure.EmailServices;

namespace TimeOffTracker.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();
            return services;
        }
    }
}
