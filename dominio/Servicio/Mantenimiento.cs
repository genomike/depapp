namespace dominio;

public class Mantenimiento : Servicio
{
    public IEnumerable<CostoVariable>? GastosMantenimiento { get; set; }

    public string? Descripcion { get; set; }

    public bool Programado { get; set; }
}