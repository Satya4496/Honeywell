using IntelliFireSystems.Samples;
using Xunit;

namespace IntelliFireSystems.EntityFrameworkCore.Domains;

[Collection(IntelliFireSystemsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<IntelliFireSystemsEntityFrameworkCoreTestModule>
{

}
