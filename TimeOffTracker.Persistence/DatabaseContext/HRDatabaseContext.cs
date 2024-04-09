using Microsoft.EntityFrameworkCore;
using TimeOffTracker.Domain;
using TimeOffTracker.Domain.Common;
using TimeOffTracker.Persistence.Configuration;

namespace TimeOffTracker.Persistence.DatabaseContext
{
    public class HRDatabaseContext : DbContext
    {
        public HRDatabaseContext(DbContextOptions<HRDatabaseContext> options) : base(options)
        {
        }

        public DbSet<LeaveType> leaveTypes { get; set; }
        public DbSet<LeaveAllocation> leaveAllocations { get; set; }
        public DbSet<LeaveRequest> leaveRequests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //call all configurations
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HRDatabaseContext).Assembly);

            //this one just call one specefic configurations

            //modelBuilder.ApplyConfiguration(new LeaveTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
           foreach (var entry in  base.ChangeTracker.Entries<BaseEntity>()
                .Where(q=> q.State== EntityState.Added || q.State== EntityState.Modified))
            {
                entry.Entity.DateModified = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }
           return base.SaveChangesAsync(cancellationToken);
        }
    }
}
