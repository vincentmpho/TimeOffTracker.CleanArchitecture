using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using TimeOffTracker.Application.Contracts.Email;
using TimeOffTracker.Application.Models.Email;

namespace TimeOffTracker.Infrastructure.EmailServices
{
    public class EmailSender : IEmailSender
    {
        public EmailSettings _emailSettings { get; set; }
        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public async Task<bool> SendEmail(EmailMesage email)
        {
            var client = new SendGridClient(_emailSettings.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName
            };
            var message = MailHelper.CreateSingleEmail(from,to,email.Subject,email.Body, email.Body);
            var response = await client.SendEmailAsync(message);

            return response.IsSuccess;

        }
    }
}
