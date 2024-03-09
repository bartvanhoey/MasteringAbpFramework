using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FormsApp.Data;

/* This is used if database provider does't define
 * IFormsAppDbSchemaMigrator implementation.
 */
public class NullFormsAppDbSchemaMigrator : IFormsAppDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
