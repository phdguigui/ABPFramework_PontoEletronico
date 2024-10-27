using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp;

namespace PontoEletronico.Pontos
{
    public class PontosAppService :
        CrudAppService<
            Ponto,
            PontoDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdatePontoDto>,
        IPontoAppService
    {
        private IRepository<Ponto, int> _repository;

        public PontosAppService(IRepository<Ponto, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<PontoDto> MarcarPontoAtual(MarcarPontoAtualDto input)
        {
            try
            {
                Ponto ponto = new Ponto()
                {
                    FuncionarioId = input.FuncionarioId,
                    Modalidade = input.Modalidade,
                    Data = DateTime.Now
                };

                await _repository.InsertAsync(ponto, true);

                return ObjectMapper.Map<Ponto, PontoDto>(ponto);
            }
            catch (Exception ex)
            {
                throw new BusinessException(ex.Message);
            }
        }
    }
}
