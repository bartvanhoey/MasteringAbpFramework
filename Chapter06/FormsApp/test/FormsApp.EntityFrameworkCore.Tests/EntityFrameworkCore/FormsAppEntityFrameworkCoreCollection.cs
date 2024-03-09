using Xunit;

namespace FormsApp.EntityFrameworkCore;

[CollectionDefinition(FormsAppTestConsts.CollectionDefinitionName)]
public class FormsAppEntityFrameworkCoreCollection : ICollectionFixture<FormsAppEntityFrameworkCoreFixture>
{

}
