using Volo.Abp.Settings;

namespace IntelliFireSystems.Settings;

public class IntelliFireSystemsSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(IntelliFireSystemsSettings.MySetting1));
    }
}
