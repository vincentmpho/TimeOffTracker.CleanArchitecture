using MediatR;

namespace TimeOffTracker.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
 
    
}
