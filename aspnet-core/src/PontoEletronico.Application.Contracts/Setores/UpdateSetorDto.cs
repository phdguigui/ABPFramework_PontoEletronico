using System.ComponentModel.DataAnnotations;

namespace PontoEletronico.Setores;

public class UpdateSetorDto
{
    [Required]
    [StringLength(128)]
    public string Nome { get; set; } = string.Empty;
    [StringLength(128)]
    public string? Sala { get; set; }
}
