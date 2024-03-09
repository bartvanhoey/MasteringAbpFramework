using Volo.Abp.Modularity;

namespace FormsApp;

[DependsOn(
    typeof(FormsAppDomainModule),
    typeof(FormsAppTestBaseModule)
)]
public class FormsAppDomainTestModule : AbpModule
{

}
