using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PontoEletronico.Setores;

public interface ISetorAppService : IApplicationService
{
    Task<SetorDto> GetAsync(int id);

    Task<PagedResultDto<SetorDto>> GetListAsync(GetSetorListDto input);

    Task<SetorDto> CreateAsync(CreateSetorDto input);

    Task UpdateAsync(int id, UpdateSetorDto input);

    Task DeleteAsync(int id);
}
