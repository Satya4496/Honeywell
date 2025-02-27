using Volo.Abp.Modularity;

namespace IntelliFireSystems;

public abstract class IntelliFireSystemsApplicationTestBase<TStartupModule> : IntelliFireSystemsTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
