using System.ComponentModel.DataAnnotations;

namespace PontoEletronico.Setores;

public class CreateSetorDto
{
    [Required]
    [StringLength(128)]
    public string Nome { get; set; } = string.Empty;
    [StringLength(128)]
    public string? Sala { get; set; }
}
