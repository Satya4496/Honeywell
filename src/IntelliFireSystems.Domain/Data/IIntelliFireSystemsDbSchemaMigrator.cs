using System.Threading.Tasks;

namespace IntelliFireSystems.Data;

public interface IIntelliFireSystemsDbSchemaMigrator
{
    Task MigrateAsync();
}
