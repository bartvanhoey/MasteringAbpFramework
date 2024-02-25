using DemoApp.Samples;
using Xunit;

namespace DemoApp.EntityFrameworkCore.Applications;

[Collection(DemoAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<DemoAppEntityFrameworkCoreTestModule>
{

}
