using MediatR;

namespace TimeOffTracker.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeQuery
    {
        public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>; 
    }
}
