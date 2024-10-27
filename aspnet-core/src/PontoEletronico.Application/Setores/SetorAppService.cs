using Microsoft.AspNetCore.Authorization;
using PontoEletronico;
using PontoEletronico.Setores;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using PontoEletronico.Permissions;

namespace PontoEletronico.Setores;

//[Authorize(PontoEletronicoPermissions.Setores.Default)]
public class AuthorAppService : PontoEletronicoAppService, ISetorAppService
{
    private readonly ISetorRepository _setorRepository;

    public AuthorAppService(
        ISetorRepository authorRepository)
    {
        _setorRepository = authorRepository;
    }

    //[Authorize(PontoEletronicoPermissions.Setores.Create)]
    public async Task<SetorDto> CreateAsync(CreateSetorDto input)
    {
        Setor setor = new Setor()
        {
            Nome = input.Nome,
            Sala = input.Sala
        };

        await _setorRepository.InsertAsync(setor);

        return ObjectMapper.Map<Setor, SetorDto>(setor);
    }

    //[Authorize(PontoEletronicoPermissions.Setores.Delete)]
    public async Task DeleteAsync(int id)
    {
        await _setorRepository.DeleteAsync(id);
    }

    public async Task<SetorDto> GetAsync(int id)
    {
        var setor = await _setorRepository.GetAsync(id);
        return ObjectMapper.Map<Setor, SetorDto>(setor);
    }

    public async Task<PagedResultDto<SetorDto>> GetListAsync(GetSetorListDto input)
    {
        if (input.Sorting.IsNullOrWhiteSpace())
        {
            input.Sorting = nameof(Setor.Nome);
        }

        var setores = await _setorRepository.GetListAsync(
            input.SkipCount,
            input.MaxResultCount,
            input.Sorting,
            input.Filter
        );

        var totalCount = input.Filter == null
            ? await _setorRepository.CountAsync()
            : await _setorRepository.CountAsync(
                setor => setor.Nome.Contains(input.Filter));

        return new PagedResultDto<SetorDto>(
            totalCount,
            ObjectMapper.Map<List<Setor>, List<SetorDto>>(setores)
        );
    }

    //[Authorize(PontoEletronicoPermissions.Setores.Edit)]
    public async Task UpdateAsync(int id, UpdateSetorDto input)
    {
        var setor = await _setorRepository.GetAsync(id);

        if (setor.Nome != input.Nome)
        {
            setor.Nome = input.Nome;
        }
        if (setor.Sala !=  input.Sala)
        {
            setor.Sala = input.Sala;
        }

        await _setorRepository.UpdateAsync(setor);
    }
}
