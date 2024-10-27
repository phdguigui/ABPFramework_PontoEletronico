using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace PontoEletronico.Data;

/* This is used if database provider does't define
 * IPontoEletronicoDbSchemaMigrator implementation.
 */
public class NullPontoEletronicoDbSchemaMigrator : IPontoEletronicoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
