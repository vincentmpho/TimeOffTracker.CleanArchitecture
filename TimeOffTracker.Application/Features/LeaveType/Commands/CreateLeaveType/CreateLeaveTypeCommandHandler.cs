using AutoMapper;
using MediatR;
using TimeOffTracker.Application.Contracts.Data_Access;

namespace TimeOffTracker.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            //Validate incoming data

            //Convert to Domain entity object
            var leaveTypeToCreate = _mapper.Map<Domain.LeaveType>(request);

            //Add to Database
            await _leaveTypeRepository.CreateAsync(leaveTypeToCreate);
            //Return record id
            return leaveTypeToCreate.Id;
        }
    }
}
