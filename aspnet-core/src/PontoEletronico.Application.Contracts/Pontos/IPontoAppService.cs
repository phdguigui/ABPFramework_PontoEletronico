using PontoEletronico.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PontoEletronico.Pontos
{
    public interface IPontoAppService :
        ICrudAppService<
            PontoDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdatePontoDto>
    {
    }
}
