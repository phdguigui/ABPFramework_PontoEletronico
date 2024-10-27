using AutoMapper;
using PontoEletronico.Funcionarios;
using PontoEletronico.Pontos;
using PontoEletronico.Setores;

namespace PontoEletronico;

public class PontoEletronicoApplicationAutoMapperProfile : Profile
{
    public PontoEletronicoApplicationAutoMapperProfile()
    {
        CreateMap<Funcionario, FuncionarioDto>();
        CreateMap<CreateUpdateFuncionarioDto, Funcionario>();
        CreateMap<Setor, SetorDto>();
        CreateMap<Ponto, PontoDto>();
        CreateMap<CreateUpdatePontoDto, Ponto>();
        CreateMap<MarcarPontoAtualDto, Ponto>();
    }
}
