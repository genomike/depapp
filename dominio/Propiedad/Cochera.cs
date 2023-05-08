using System.ComponentModel.DataAnnotations;

namespace dominio;

public class Cochera : Propiedad
{
    [Display(Name = "Tipo de Cochera")]
    public tipoCochera Tipo { get; set; }
}