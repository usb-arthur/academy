using System.Threading.Tasks;

namespace ACADEMY.Application.EmailService
{
    public interface IEmailService
    {
        Task SendMailAsync(string email, string subject, string htmlMessage);
    }
}