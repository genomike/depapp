using System.ComponentModel.DataAnnotations;

namespace dominio;

public class Propietario : Vecino
{
    [Display(Name = "Fecha de Adquisición")]
    public DateOnly fechaAdquisicion { get; set; }

    public bool compradorOriginal { get; set; }
}