using SendEmail.Models;

namespace SendEmail.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto requet);
    }
}
