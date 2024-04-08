﻿using FluentValidation.Results;

namespace TimeOffTracker.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException(string message) : base(message)
        {
            
        }
        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            validationErrors = new();
            foreach ( var error in validationResult.Errors)
            {
                validationErrors.Add(error.ErrorMessage);
            }
        }

        public List<string> validationErrors { get; set; }
    }
}
