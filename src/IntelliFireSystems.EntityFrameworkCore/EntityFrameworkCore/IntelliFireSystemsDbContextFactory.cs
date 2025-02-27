using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace IntelliFireSystems.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class IntelliFireSystemsDbContextFactory : IDesignTimeDbContextFactory<IntelliFireSystemsDbContext>
{
    public IntelliFireSystemsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        IntelliFireSystemsEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<IntelliFireSystemsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new IntelliFireSystemsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../IntelliFireSystems.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
