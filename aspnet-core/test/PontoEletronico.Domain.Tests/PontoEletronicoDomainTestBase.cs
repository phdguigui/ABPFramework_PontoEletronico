using Volo.Abp.Modularity;

namespace PontoEletronico;

/* Inherit from this class for your domain layer tests. */
public abstract class PontoEletronicoDomainTestBase<TStartupModule> : PontoEletronicoTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
