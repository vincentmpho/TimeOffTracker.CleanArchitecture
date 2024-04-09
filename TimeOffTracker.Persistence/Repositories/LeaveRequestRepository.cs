using Microsoft.EntityFrameworkCore;
using TimeOffTracker.Application.Contracts.Data_Access;
using TimeOffTracker.Domain;
using TimeOffTracker.Persistence.DatabaseContext;

namespace TimeOffTracker.Persistence.Repositories
{
    public class LeaveRequestRepository  : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        public LeaveRequestRepository(HRDatabaseContext context) : base(context)
        {
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _context.leaveRequests
                            .Include(q=>q.LeaveType)
                            .FirstOrDefaultAsync(q=>q.Id == id);

            return leaveRequest;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestWithDetails()
        {
            var leaveRequests = await _context.leaveRequests
               .Include(q => q.LeaveType)
               .ToListAsync();

            return leaveRequests;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestWithDetails(string userId)
        {
            var leaveRequests = await _context.leaveRequests
                           .Where(q=>q.RequestingEmployeeId == userId)
                           .Include(q => q.LeaveType)
                           .ToListAsync();

            return leaveRequests;
        }
    } 


}
