using TimeOffTracker.Domain;

namespace TimeOffTracker.Application.Contracts.Data_Access
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails();
        Task<List<LeaveRequest>> GetLeaveRequestWithDetails(string userId);
    }
}
