using Volo.Abp.Modularity;

namespace FormsApp;

[DependsOn(
    typeof(FormsAppApplicationModule),
    typeof(FormsAppDomainTestModule)
)]
public class FormsAppApplicationTestModule : AbpModule
{

}
