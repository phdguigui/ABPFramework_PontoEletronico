using System.Threading.Tasks;

namespace PontoEletronico.Data;

public interface IPontoEletronicoDbSchemaMigrator
{
    Task MigrateAsync();
}
