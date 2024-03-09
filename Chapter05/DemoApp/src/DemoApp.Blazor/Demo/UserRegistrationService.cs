using System.Threading.Tasks;
using SmsSending;

namespace DemoApp.Blazor.Demo
{
    public class UserRegistrationService
    {
        private readonly ISmsService _smsService;

        public UserRegistrationService(ISmsService smsService)
        {
            _smsService = smsService;
        }

        public async Task RegisterAsync(string userName, string password, string phoneNumber)
        {
            await _smsService.SendAsync(phoneNumber, "Your verification code");
        }

    }
}