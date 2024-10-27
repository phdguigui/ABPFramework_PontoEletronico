using Volo.Abp.Application.Dtos;

namespace PontoEletronico.Setores;

public class GetSetorListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
