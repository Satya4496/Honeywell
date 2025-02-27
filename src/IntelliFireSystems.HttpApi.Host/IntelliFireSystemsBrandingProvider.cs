using Microsoft.Extensions.Localization;
using IntelliFireSystems.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace IntelliFireSystems;

[Dependency(ReplaceServices = true)]
public class IntelliFireSystemsBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<IntelliFireSystemsResource> _localizer;

    public IntelliFireSystemsBrandingProvider(IStringLocalizer<IntelliFireSystemsResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
