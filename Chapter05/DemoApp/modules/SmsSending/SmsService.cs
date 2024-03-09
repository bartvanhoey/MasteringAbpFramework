namespace SmsSending;

public class SmsService : ISmsService
{
    public async Task SendAsync(string phoneNumber, string message)
    {
        await Task.CompletedTask;
    }

    internal void Initialize()
    {
        throw new NotImplementedException();
    }
}