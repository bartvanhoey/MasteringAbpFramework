using Volo.Abp.Modularity;

namespace FormsApp;

/* Inherit from this class for your domain layer tests. */
public abstract class FormsAppDomainTestBase<TStartupModule> : FormsAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
