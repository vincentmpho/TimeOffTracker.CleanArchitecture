﻿using MediatR;

namespace TimeOffTracker.Application.Features.LeaveType.Commands.UpdateLeaveType
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public string Name { get; set; }
        public int  DefaultDays { get; set; }
    }
}
