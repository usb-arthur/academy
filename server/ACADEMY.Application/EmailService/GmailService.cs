using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace ACADEMY.Application.EmailService
{
    public class GmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public GmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public async Task SendMailAsync(string email, string subject, string htmlMessage)
        {
            var mailMessage = new MailMessage {From = new MailAddress(_configuration["EmailSettings:Sender"])};
            mailMessage.To.Add(new MailAddress(email));
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = htmlMessage;

            var client = new SmtpClient
            {
                Credentials = new System.Net.NetworkCredential(_configuration["EmailSettings:Sender"], _configuration["EmailSettings:Password"]),
                Host = _configuration["EmailSettings:MailServer"],
                Port = int.Parse(_configuration["EmailSettings:MailPort"]),
                EnableSsl = true
            };
            
            await client.SendMailAsync(mailMessage);
        }
    }
}