using System;
using System.Collections.Generic;
using System.Text;
using FormsApp.Localization;
using Volo.Abp.Application.Services;

namespace FormsApp;

/* Inherit your application services from this class.
 */
public abstract class FormsAppAppService : ApplicationService
{
    protected FormsAppAppService()
    {
        LocalizationResource = typeof(FormsAppResource);
    }
}
