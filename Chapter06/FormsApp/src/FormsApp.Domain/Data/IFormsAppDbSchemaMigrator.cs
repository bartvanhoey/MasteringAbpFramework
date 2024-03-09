using System.Threading.Tasks;

namespace FormsApp.Data;

public interface IFormsAppDbSchemaMigrator
{
    Task MigrateAsync();
}
