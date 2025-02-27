using Volo.Abp.Modularity;

namespace IntelliFireSystems;

[DependsOn(
    typeof(IntelliFireSystemsApplicationModule),
    typeof(IntelliFireSystemsDomainTestModule)
)]
public class IntelliFireSystemsApplicationTestModule : AbpModule
{

}
