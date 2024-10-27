using PontoEletronico.Funcionarios;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using System;

namespace PontoEletronico
{
    public class PontoEletronicoSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Funcionario, int> _funcionarioRepository;

        public PontoEletronicoSeedContributor(IRepository<Funcionario, int> funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _funcionarioRepository.GetCountAsync() <= 0)
            {
                await _funcionarioRepository.InsertAsync
                    (
                        new Funcionario
                        {
                            Nome = "Guilherme",
                            Sobrenome = "Siedschlag",
                            DataNascimento = new DateTime(day: 31, month: 3, year: 2002),
                            Salario = 1000,
                            CPF = "12345678910",
                            SetorId = 2
                        },
                        true
                    );

                await _funcionarioRepository.InsertAsync
                    (
                        new Funcionario
                        {
                            Nome = "Gabrielli",
                            Sobrenome = "Siedschlag",
                            DataNascimento = new DateTime(day: 3, month: 4, year: 2014),
                            Salario = 2000,
                            CPF = "12345678911",
                            SetorId = 1
                        },
                        true
                    );
            }
        }
    }
}
