using Microsoft.Extensions.Localization;
using PontoEletronico.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PontoEletronico;

[Dependency(ReplaceServices = true)]
public class PontoEletronicoBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<PontoEletronicoResource> _localizer;

    public PontoEletronicoBrandingProvider(IStringLocalizer<PontoEletronicoResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
