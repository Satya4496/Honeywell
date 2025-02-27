using IntelliFireSystems.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace IntelliFireSystems.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(IntelliFireSystemsEntityFrameworkCoreModule),
    typeof(IntelliFireSystemsApplicationContractsModule)
)]
public class IntelliFireSystemsDbMigratorModule : AbpModule
{
}
