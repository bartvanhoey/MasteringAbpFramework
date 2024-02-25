using Volo.Abp.Modularity;

namespace DemoApp;

[DependsOn(
    typeof(DemoAppDomainModule),
    typeof(DemoAppTestBaseModule)
)]
public class DemoAppDomainTestModule : AbpModule
{

}
