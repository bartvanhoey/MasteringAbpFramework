using FormsApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FormsApp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FormsAppEntityFrameworkCoreModule),
    typeof(FormsAppApplicationContractsModule)
    )]
public class FormsAppDbMigratorModule : AbpModule
{
}
