using System.ComponentModel.DataAnnotations;

namespace dominio;

public class CostoVariable
{
    [Display(Name = "Fecha del Gasto")]
    public DateOnly FechaGasto { get; set; }

    public decimal Costo { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }
}