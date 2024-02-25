using Volo.Abp.Modularity;

namespace DemoApp;

public abstract class DemoAppApplicationTestBase<TStartupModule> : DemoAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
