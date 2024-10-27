using Volo.Abp.Modularity;

namespace PontoEletronico;

public abstract class PontoEletronicoApplicationTestBase<TStartupModule> : PontoEletronicoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
