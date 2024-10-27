using System;
using System.Collections.Generic;
using System.Text;
using PontoEletronico.Localization;
using Volo.Abp.Application.Services;

namespace PontoEletronico;

/* Inherit your application services from this class.
 */
public abstract class PontoEletronicoAppService : ApplicationService
{
    protected PontoEletronicoAppService()
    {
        LocalizationResource = typeof(PontoEletronicoResource);
    }
}
