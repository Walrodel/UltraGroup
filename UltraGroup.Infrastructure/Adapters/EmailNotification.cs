using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using UltraGroup.Application.Ports;
using UltraGroup.Domain.Exceptions;

namespace UltraGroup.Infrastructure.Adapters
{
    internal class EmailNotification(IConfiguration configuration) : IEmailNotification
    {
        public async Task SendEmailAsync(string to, string subject, string body)
        {
            string smtpServer = configuration.GetValue<string>("Notification:smtpServer") ?? throw new RequiredException("The smtpServer is required.");
            int smtpPort = configuration.GetValue<int>("Notification:smtpPort");
            string smtpUser = configuration.GetValue<string>("Notification:smtpUser") ?? throw new RequiredException("The smtpUser is required.");
            string smtpPass = configuration.GetValue<string>("Notification:smtpPass") ?? throw new RequiredException("The smtpPass is required.");

            var smtpClient = new SmtpClient(smtpServer)
            {
                Port = smtpPort,
                Credentials = new NetworkCredential(smtpUser, smtpPass),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress(smtpUser),
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            mailMessage.To.Add(to);

            try
            {
                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception)
            {
                throw new CoreBusinessException("Error send email.");
            }
        }
    }
}
