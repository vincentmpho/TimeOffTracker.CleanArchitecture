using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeOffTracker.Application.Features.LeaveType.Commands.CreateLeaveType
{
    public class CreateLeaveTypeCommandValidator : AbstractValidator<CreateLeaveTypeCommand>
    {
        public CreateLeaveTypeCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{propertyName} is required")
                .NotNull()
                .MaximumLength(70).WithMessage("{propertyName} must be fewer than 70 characters");

            RuleFor(p => p.DefaultDays)
                    .LessThan(100).WithMessage("{propertyName} cannot be less than 1")
                .GreaterThan(1).WithMessage("{properyName} cannot exceed 1");



        }

    }
}
