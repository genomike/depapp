using dominio.Comun;
using System.ComponentModel.DataAnnotations;

namespace dominio;

public class Comprobante : iEntidad
{
    [Required]
    public int Id { get; set; }

    [Required]
    public Vecino Vecino { get; set; }

    [Required]
    public DateOnly Periodo { get; set; }

    [Required]
    [Range(minimum: 1, maximum: 9999)]
    public decimal Monto { get; set; }

    [Required]
    [Display(Name = "Número de Comprobante")]
    [StringLength(10, ErrorMessage = "El formato es incorrecto", MinimumLength = 4)]
    public string NumeroComprobante { get; set; }

    [Required]
    [Display(Name = "Número de Operación")]
    public string NumeroOperacion { get; set; }

    [Required]
    [Display(Name = "Fecha")]
    public DateTime FechaGeneracion { get; set; }

    public CambioEstado? CambioEstado { get; set; }
}