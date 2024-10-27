using System;
using Volo.Abp.Domain.Entities;

namespace PontoEletronico.Funcionarios
{
    public class FuncionarioDto : Entity<int>
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal Salario { get; set; }
        public int SetorId { get; set; }
    }
}
