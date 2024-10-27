using System;
using System.ComponentModel.DataAnnotations;

namespace PontoEletronico.Funcionarios
{
    public class CreateUpdateFuncionarioDto
    {
        [Required]
        [StringLength(128)]
        public string Nome { get; set; }
        [Required]
        [StringLength(128)]
        public string Sobrenome { get; set; }
        [Required]
        [StringLength(11)]
        public string CPF { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public decimal Salario { get; set; }
        public int SetorId { get; set; }
    }
}
