using System;
using System.ComponentModel.DataAnnotations;

namespace PontoEletronico.Pontos
{
    public class CreateUpdatePontoDto
    {
        [Required]
        public int FuncionarioId { get; set; }
        [Required]
        public DateTime Data { get; set; }
        [Required]
        public EnumModalidade Modalidade { get; set; }
    }
}
