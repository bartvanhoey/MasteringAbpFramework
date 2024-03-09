using Volo.Abp.Settings;

namespace FormsApp.Settings;

public class FormsAppSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FormsAppSettings.MySetting1));
    }
}
