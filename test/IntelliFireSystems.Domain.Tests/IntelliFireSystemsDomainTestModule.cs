using Volo.Abp.Modularity;

namespace IntelliFireSystems;

[DependsOn(
    typeof(IntelliFireSystemsDomainModule),
    typeof(IntelliFireSystemsTestBaseModule)
)]
public class IntelliFireSystemsDomainTestModule : AbpModule
{

}
