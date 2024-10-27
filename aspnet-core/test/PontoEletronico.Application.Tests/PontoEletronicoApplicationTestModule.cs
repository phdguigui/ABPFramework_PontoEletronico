using Volo.Abp.Modularity;

namespace PontoEletronico;

[DependsOn(
    typeof(PontoEletronicoApplicationModule),
    typeof(PontoEletronicoDomainTestModule)
)]
public class PontoEletronicoApplicationTestModule : AbpModule
{

}
