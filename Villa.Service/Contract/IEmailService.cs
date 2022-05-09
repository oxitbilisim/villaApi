using Villa.Domain.Settings;
using System.Threading.Tasks;

namespace Villa.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
