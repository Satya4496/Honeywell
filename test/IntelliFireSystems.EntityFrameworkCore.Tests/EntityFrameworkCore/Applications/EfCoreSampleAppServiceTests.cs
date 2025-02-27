using IntelliFireSystems.Samples;
using Xunit;

namespace IntelliFireSystems.EntityFrameworkCore.Applications;

[Collection(IntelliFireSystemsTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<IntelliFireSystemsEntityFrameworkCoreTestModule>
{

}
