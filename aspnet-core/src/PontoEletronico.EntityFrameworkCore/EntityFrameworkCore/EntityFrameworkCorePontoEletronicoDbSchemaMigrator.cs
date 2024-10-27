using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PontoEletronico.Data;
using Volo.Abp.DependencyInjection;

namespace PontoEletronico.EntityFrameworkCore;

public class EntityFrameworkCorePontoEletronicoDbSchemaMigrator
    : IPontoEletronicoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCorePontoEletronicoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the PontoEletronicoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PontoEletronicoDbContext>()
            .Database
            .MigrateAsync();
    }
}
