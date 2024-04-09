using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TimeOffTracker.Persistence.DatabaseContext;
using TimeOffTracker.Application.Contracts.Data_Access;
using TimeOffTracker.Persistence.Repositories;

namespace TimeOffTracker.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            //register DB context
            services.AddDbContext<HRDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("HRDatabaseConnectionString"));
            });

            //Register Repository
            services.AddScoped (typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddScoped<ILeaveTypeRepository, LeaveTypeRepository>();
            services.AddScoped<ILeaveAllocationRepository, LeaveAllocationRepository>();
            services.AddScoped<ILeaveRequestRepository, LeaveRequestRepository>();
            return services;
        }
    }
}
