using AutoMapper;
using TimeOffTracker.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using TimeOffTracker.Domain;

namespace TimeOffTracker.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile() 
        {
            //source to,  Destination
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDetailsDto>().ReverseMap();
        }
    }
}
