using dominio.Comun;
using System.ComponentModel.DataAnnotations;

namespace dominio;

public abstract class Propiedad : iEntidad
{
    [Required]
    public int Id { get; set; }

    public IEnumerable<Vecino>? Vecino { get; set; }

    [StringLength(10, ErrorMessage = "El texto es invalido", MinimumLength = 3)]
    [Display(Name = "Número de Propiedad")]
    public string? Numero { get; set; }

    [Required]
    [Range(0, 250)]
    public decimal Metraje { get; set; }

    public IEnumerable<Servicio>? Servicios { get; set; }
}