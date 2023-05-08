using System.ComponentModel.DataAnnotations;

namespace dominio;

public class Departamento : Propiedad
{
    [Display(Name = "Tipo de Departamento")]
    public tipoDepartamento Tipo { get; set; }
}