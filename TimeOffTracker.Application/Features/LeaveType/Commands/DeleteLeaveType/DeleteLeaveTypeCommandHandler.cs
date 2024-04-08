using MediatR;
using TimeOffTracker.Application.Contracts.Data_Access;

namespace TimeOffTracker.Application.Features.LeaveType.Commands.DeleteLeaveType
{
    public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
    {
        
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public DeleteLeaveTypeCommandHandler( ILeaveTypeRepository leaveTypeRepository)
        {
            
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //Convert to domain entity object
            var leaveTypeToDelete = await _leaveTypeRepository.GetByIdAsync(request.Id);

            // veerify that  records

            //Remove from database
            await _leaveTypeRepository.DeleteAsync(leaveTypeToDelete);


            //return record id
            return Unit.Value;
        }
    }
}
