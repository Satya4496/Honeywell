using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace IntelliFireSystems.Data;

/* This is used if database provider does't define
 * IIntelliFireSystemsDbSchemaMigrator implementation.
 */
public class NullIntelliFireSystemsDbSchemaMigrator : IIntelliFireSystemsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
