using PontoEletronico.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace PontoEletronico.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(PontoEletronicoEntityFrameworkCoreModule),
    typeof(PontoEletronicoApplicationContractsModule)
    )]
public class PontoEletronicoDbMigratorModule : AbpModule
{
}
