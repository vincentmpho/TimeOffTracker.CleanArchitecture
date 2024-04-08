using AutoMapper;
using MediatR;
using TimeOffTracker.Application.Contracts.Data_Access;
using static TimeOffTracker.Application.Features.LeaveType.Queries.GetLeaveTypeDetails.GetLeaveTypeQuery;

namespace TimeOffTracker.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    public class GetLeaveTypeDetailsQueryHandler : IRequestHandler<GetLeaveTypeDetailsQuery,
        LeaveTypeDetailsDto>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeDetailsQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }

        public async Task<LeaveTypeDetailsDto> Handle(GetLeaveTypeDetailsQuery request, CancellationToken cancellationToken)
        {
            //Query the database
            var leaveTypes = await _leaveTypeRepository.GetByIdAsync(request.Id);

            //Convert data object to DTO Objects
            var  data = _mapper.Map<LeaveTypeDetailsDto>(leaveTypes);

            //return DTO object
            return data;

        }
    }
}
