using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace PontoEletronico.Setores
{
    public interface ISetorRepository : IRepository<Setor, int>
    {
        Task<Setor> GetById(int id);
        Task<List<Setor>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting
,
            string? filter);
    }
}
