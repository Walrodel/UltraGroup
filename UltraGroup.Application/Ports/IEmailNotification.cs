namespace UltraGroup.Application.Ports
{
    public interface IEmailNotification
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
