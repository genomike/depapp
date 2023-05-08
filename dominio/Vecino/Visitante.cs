using System.ComponentModel.DataAnnotations;

namespace dominio;

public class Visitante : Vecino
{
    [Display(Name = "Inicio de la Visita")]
    public IEnumerable<DateOnly>? InicioVisita { get; set; }

    [Display(Name = "Termino de la Visita")]
    public IEnumerable<DateOnly>? TerminoVisita { get; set; }
}