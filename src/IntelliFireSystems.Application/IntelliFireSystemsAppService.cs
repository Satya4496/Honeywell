using IntelliFireSystems.Localization;
using Volo.Abp.Application.Services;

namespace IntelliFireSystems;

/* Inherit your application services from this class.
 */
public abstract class IntelliFireSystemsAppService : ApplicationService
{
    protected IntelliFireSystemsAppService()
    {
        LocalizationResource = typeof(IntelliFireSystemsResource);
    }
}
