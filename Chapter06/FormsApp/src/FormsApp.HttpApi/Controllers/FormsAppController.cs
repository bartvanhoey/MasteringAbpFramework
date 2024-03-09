using FormsApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace FormsApp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class FormsAppController : AbpControllerBase
{
    protected FormsAppController()
    {
        LocalizationResource = typeof(FormsAppResource);
    }
}
