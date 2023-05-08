using dominio.Comun;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace dominio;

public abstract class Servicio : iEntidad
{
    [Required]
    public int Id { get; set; }

    [Range(minimum: 1, maximum: 9999)]
    public decimal CostoFijo { get; set; }

    public DateOnly Fecha { get; set; }

    [Required]
    [Display(Name = "Nombre del Servicio")]
    public string Nombre { get; set; }
}