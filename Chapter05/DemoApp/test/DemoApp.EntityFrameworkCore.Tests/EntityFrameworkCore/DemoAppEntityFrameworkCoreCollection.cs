using Xunit;

namespace DemoApp.EntityFrameworkCore;

[CollectionDefinition(DemoAppTestConsts.CollectionDefinitionName)]
public class DemoAppEntityFrameworkCoreCollection : ICollectionFixture<DemoAppEntityFrameworkCoreFixture>
{

}
