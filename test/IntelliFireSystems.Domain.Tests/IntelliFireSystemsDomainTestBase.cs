using Volo.Abp.Modularity;

namespace IntelliFireSystems;

/* Inherit from this class for your domain layer tests. */
public abstract class IntelliFireSystemsDomainTestBase<TStartupModule> : IntelliFireSystemsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
