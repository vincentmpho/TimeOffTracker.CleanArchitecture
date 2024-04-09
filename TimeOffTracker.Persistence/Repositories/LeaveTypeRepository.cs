using Microsoft.EntityFrameworkCore;
using TimeOffTracker.Application.Contracts.Data_Access;
using TimeOffTracker.Domain;
using TimeOffTracker.Persistence.DatabaseContext;

namespace TimeOffTracker.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(HRDatabaseContext context) : base(context)
        {
        }

        public async Task<bool> IsLeaveTypeUnique(string name)
        {
            return await _context.leaveTypes.AnyAsync(x => x.Name == name);
        }
    }


}
