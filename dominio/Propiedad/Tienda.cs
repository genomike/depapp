using System.ComponentModel.DataAnnotations;

namespace dominio;

public class Tienda : Propiedad
{
    [Display(Name = "Giro del Negocio")]
    public string? GiroDeNegocio { get; set; }
}