using dominio.Comun;

namespace dominio;

public abstract class Propiedad : iEntidad
{
    public int Id { get; set; }

    public List<Vecino> Vecino { get; set; }

    public tipoPropiedad Tipo { get; set; }

    public string Numero { get; set; }

    public decimal Metraje { get; set; }

    public List<Servicio> Servicios { get; set; }
}