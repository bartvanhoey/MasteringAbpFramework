using Volo.Abp.Modularity;

namespace FormsApp;

public abstract class FormsAppApplicationTestBase<TStartupModule> : FormsAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
