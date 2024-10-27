using Volo.Abp.Application.Dtos;

namespace PontoEletronico.Setores;

public class SetorDto : EntityDto<int>
{
    public string Nome { get; set; }
    public string Sala { get; set; }
}
