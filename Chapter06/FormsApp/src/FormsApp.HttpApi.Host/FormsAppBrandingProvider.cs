using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FormsApp;

[Dependency(ReplaceServices = true)]
public class FormsAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "FormsApp";
}
