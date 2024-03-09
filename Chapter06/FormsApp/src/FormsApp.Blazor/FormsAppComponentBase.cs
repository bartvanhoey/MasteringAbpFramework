using FormsApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace FormsApp.Blazor;

public abstract class FormsAppComponentBase : AbpComponentBase
{
    protected FormsAppComponentBase()
    {
        LocalizationResource = typeof(FormsAppResource);
    }
}
