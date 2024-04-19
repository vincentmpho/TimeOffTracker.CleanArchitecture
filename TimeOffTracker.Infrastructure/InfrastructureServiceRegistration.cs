using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeOffTracker.Application.Contracts.Email;
using TimeOffTracker.Application.Logging;
using TimeOffTracker.Application.Models.Email;
using TimeOffTracker.Infrastructure.EmailServices;
using TimeOffTracker.Infrastructure.Logging;

namespace TimeOffTracker.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration) 
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdpter<>));
            return services;
        }
    }
}
