using IntelliFireSystems.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IntelliFireSystems.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class IntelliFireSystemsController : AbpControllerBase
{
    protected IntelliFireSystemsController()
    {
        LocalizationResource = typeof(IntelliFireSystemsResource);
    }
}
