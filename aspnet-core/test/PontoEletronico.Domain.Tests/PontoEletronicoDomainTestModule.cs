using Volo.Abp.Modularity;

namespace PontoEletronico;

[DependsOn(
    typeof(PontoEletronicoDomainModule),
    typeof(PontoEletronicoTestBaseModule)
)]
public class PontoEletronicoDomainTestModule : AbpModule
{

}
