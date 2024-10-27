using System.ComponentModel.DataAnnotations;

namespace PontoEletronico.Pontos
{
    public class MarcarPontoAtualDto
    {
        [Required]
        public int FuncionarioId { get; set; }
        [Required]
        public EnumModalidade Modalidade { get; set; }
    }
}
