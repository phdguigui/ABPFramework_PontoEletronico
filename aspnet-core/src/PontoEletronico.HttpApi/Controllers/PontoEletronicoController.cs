using PontoEletronico.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace PontoEletronico.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class PontoEletronicoController : AbpControllerBase
{
    protected PontoEletronicoController()
    {
        LocalizationResource = typeof(PontoEletronicoResource);
    }
}
