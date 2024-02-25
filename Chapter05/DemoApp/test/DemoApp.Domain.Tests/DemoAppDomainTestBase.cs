using Volo.Abp.Modularity;

namespace DemoApp;

/* Inherit from this class for your domain layer tests. */
public abstract class DemoAppDomainTestBase<TStartupModule> : DemoAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
