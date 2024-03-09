using FormsApp.Samples;
using Xunit;

namespace FormsApp.EntityFrameworkCore.Applications;

[Collection(FormsAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<FormsAppEntityFrameworkCoreTestModule>
{

}
