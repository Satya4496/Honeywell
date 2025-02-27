using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using IntelliFireSystems.Data;
using Volo.Abp.DependencyInjection;

namespace IntelliFireSystems.EntityFrameworkCore;

public class EntityFrameworkCoreIntelliFireSystemsDbSchemaMigrator
    : IIntelliFireSystemsDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreIntelliFireSystemsDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the IntelliFireSystemsDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<IntelliFireSystemsDbContext>()
            .Database
            .MigrateAsync();
    }
}
