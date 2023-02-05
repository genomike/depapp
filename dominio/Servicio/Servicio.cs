using dominio.Comun;

namespace dominio;

public abstract class Servicio : iEntidad
{
    public int Id { get; set; }

    public decimal CostoFijo { get; set; }

    public DateOnly Fecha { get; set; }

    public string? Nombre { get; set; }
}