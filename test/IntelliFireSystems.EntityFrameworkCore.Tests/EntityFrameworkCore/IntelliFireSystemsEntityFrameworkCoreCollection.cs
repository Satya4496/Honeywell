using Xunit;

namespace IntelliFireSystems.EntityFrameworkCore;

[CollectionDefinition(IntelliFireSystemsTestConsts.CollectionDefinitionName)]
public class IntelliFireSystemsEntityFrameworkCoreCollection : ICollectionFixture<IntelliFireSystemsEntityFrameworkCoreFixture>
{

}
