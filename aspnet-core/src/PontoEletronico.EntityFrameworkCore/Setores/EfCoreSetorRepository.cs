using Microsoft.EntityFrameworkCore;
using PontoEletronico.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace PontoEletronico.Setores;

public class EfCoreSetorRepository
    : EfCoreRepository<PontoEletronicoDbContext, Setor, int>,
        ISetorRepository
{
    private PontoEletronicoDbContext _context;

    public EfCoreSetorRepository(
        IDbContextProvider<PontoEletronicoDbContext> dbContextProvider,
        PontoEletronicoDbContext pontoEletronicoDbContext)
        : base(dbContextProvider)
    {
        _context = pontoEletronicoDbContext;
    }

    public async Task DeleteAsync(int id, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        var dbSet = await GetDbSetAsync();
        var entity = await dbSet.FindAsync(new object[] { id }, cancellationToken);
        if (entity != null)
        {
            dbSet.Remove(entity);
            if (autoSave)
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }

    public async Task DeleteManyAsync(IEnumerable<int> ids, bool autoSave = false, CancellationToken cancellationToken = default)
    {
        var dbSet = await GetDbSetAsync();
        var entities = await dbSet.Where(e => ids.Contains(e.Id)).ToListAsync(cancellationToken);

        if (entities.Any())
        {
            dbSet.RemoveRange(entities);
            if (autoSave)
            {
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }

    public async Task<Setor?> FindAsync(int id, bool includeDetails = true, CancellationToken cancellationToken = default)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet.FindAsync(new object[] { id }, cancellationToken);
    }

    public async Task<Setor> GetAsync(int id, bool includeDetails = true, CancellationToken cancellationToken = default)
    {
        var dbSet = await GetDbSetAsync();
        var entity = await dbSet.FindAsync(new object[] { id }, cancellationToken);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Setor with ID {id} not found.");
        }
        return entity;
    }

    async Task<Setor?> ISetorRepository.GetById(int id)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet.FirstOrDefaultAsync(setor => setor.Id == id);
    }

    public async Task<List<Setor>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string? filter)
    {
        var dbSet = await GetDbSetAsync();
        return await dbSet
            .OrderBy(sorting)
            .Skip(skipCount)
            .Take(maxResultCount)
            .ToListAsync();
    }
}
