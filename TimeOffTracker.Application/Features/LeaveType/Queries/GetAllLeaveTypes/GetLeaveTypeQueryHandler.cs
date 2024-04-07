using AutoMapper;
using MediatR;
using TimeOffTracker.Application.Contracts.Data_Access;

namespace TimeOffTracker.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    public class GetLeaveTypeQueryHandler : IRequestHandler<GetLeaveTypesQuery,
        List<LeaveTypeDto>>
    {
        private readonly IMapper _mapper;
        private readonly ILeaveTypeRepository _leaveTypeRepository;

        public GetLeaveTypeQueryHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypesQuery request, CancellationToken cancellationToken)
        {

            //Query the databse
            var leaveTypes = await _leaveTypeRepository.GetAsync();

            //Convert data object to DTO objects
            var data =_mapper.Map<List<LeaveTypeDto>>(leaveTypes);

            //return List of Dto object
            return data;
        }
    }
}
