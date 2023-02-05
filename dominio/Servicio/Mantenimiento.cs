namespace dominio;

public class Mantenimiento : Servicio
{
    public List<CostoVariable>? GastosMantenimiento { get; set; }

    public string? Descripcion { get; set; }

    public bool Programado { get; set; }
}