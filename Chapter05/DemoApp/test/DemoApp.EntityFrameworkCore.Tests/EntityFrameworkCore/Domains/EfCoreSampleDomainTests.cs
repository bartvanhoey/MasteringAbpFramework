using DemoApp.Samples;
using Xunit;

namespace DemoApp.EntityFrameworkCore.Domains;

[Collection(DemoAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<DemoAppEntityFrameworkCoreTestModule>
{

}
