using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;
using Volo.Abp.Modularity;

namespace SmsSending;

public class SmsSendingModule :  AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddTransient<ISmsService, SmsService>();
    }


    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var smsService =  context.ServiceProvider.GetRequiredService<SmsService>();
        smsService.Initialize();
    }


}
