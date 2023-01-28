namespace dominio;

public class Propietario : Vecino
{
    public DateOnly fechaAdquisicion { get; set; }

    public bool compradorOriginal { get; set; }
}