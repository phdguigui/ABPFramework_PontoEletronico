using Volo.Abp.Settings;

namespace PontoEletronico.Settings;

public class PontoEletronicoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(PontoEletronicoSettings.MySetting1));
    }
}
