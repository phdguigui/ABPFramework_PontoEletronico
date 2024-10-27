using PontoEletronico.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PontoEletronico.Funcionarios
{
    public class FuncionarioAppService : 
        CrudAppService<
            Funcionario,
            FuncionarioDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateFuncionarioDto>,
        IFuncionarioAppService
    {
        public FuncionarioAppService(IRepository<Funcionario, int> repository)
            : base (repository)
        {
            //GetPolicyName = PontoEletronicoPermissions.Funcionarios.Default;
            //GetListPolicyName = PontoEletronicoPermissions.Funcionarios.Default;
            //CreatePolicyName = PontoEletronicoPermissions.Funcionarios.Create;
            //UpdatePolicyName = PontoEletronicoPermissions.Funcionarios.Edit;
            //DeletePolicyName = PontoEletronicoPermissions.Funcionarios.Delete;
        }
    }
}
