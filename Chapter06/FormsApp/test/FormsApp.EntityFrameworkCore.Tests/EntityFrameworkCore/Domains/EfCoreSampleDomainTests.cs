using FormsApp.Samples;
using Xunit;

namespace FormsApp.EntityFrameworkCore.Domains;

[Collection(FormsAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<FormsAppEntityFrameworkCoreTestModule>
{

}
