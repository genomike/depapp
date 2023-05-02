namespace dominio;

public class Visitante : Vecino
{
    public IEnumerable<DateOnly>? InicioVisita { get; set; }

    public IEnumerable<DateOnly>? TerminoVisita { get; set; }
}