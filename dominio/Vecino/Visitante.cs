namespace dominio;

public class Visitante : Vecino
{
    public List<DateOnly> InicioVisita { get; set; }

    public List<DateOnly> TerminoVisita { get; set; }
}