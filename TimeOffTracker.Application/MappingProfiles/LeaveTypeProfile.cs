using AutoMapper;
using TimeOffTracker.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using TimeOffTracker.Domain;

namespace TimeOffTracker.Application.MappingProfiles
{
    public class LeaveTypeProfile : Profile
    {
        public LeaveTypeProfile() 
        {
            CreateMap<LeaveTypeDto, LeaveType>().ReverseMap();
        }
    }
}
