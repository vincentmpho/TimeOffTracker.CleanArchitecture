using TimeOffTracker.Application.Models.Email;

namespace TimeOffTracker.Application.Contracts.Email
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(EmailMesage email);
    }
}
