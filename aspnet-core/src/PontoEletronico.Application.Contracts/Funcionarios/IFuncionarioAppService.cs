using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace PontoEletronico.Funcionarios
{
    public interface IFuncionarioAppService :
        ICrudAppService<
            FuncionarioDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateFuncionarioDto>
    {
    }
}
