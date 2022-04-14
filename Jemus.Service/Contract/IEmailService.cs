using Jemus.Domain.Settings;
using System.Threading.Tasks;

namespace Jemus.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
