using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

public class EmailService
{
    private readonly IConfiguration _config;

    public EmailService(IConfiguration config)
    {
        _config = config;
    }

    public async Task SendEmailAsync(string from, string subject, string body)
    {
        var smtp = _config.GetSection("Smtp");
        var client = new SmtpClient(smtp["Host"], int.Parse(smtp["Port"]))
        {
            Credentials = new NetworkCredential(smtp["User"], smtp["Password"]),
            EnableSsl = bool.Parse(smtp["EnableSsl"])
        };

        var message = new MailMessage
        {
            From = new MailAddress(smtp["User"]),
            Subject = subject,
            Body = body,
            IsBodyHtml = false
        };

        message.To.Add(smtp["User"]);

        if (!string.IsNullOrEmpty(from))
            message.ReplyToList.Add(new MailAddress(from));

        await client.SendMailAsync(message);
    }
}