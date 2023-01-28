using dominio.Comun;

namespace dominio;

public class Factura : iEntidad
{
    public int Id { get; set; }

    public Vecino Vecino { get; set; }

    public DateOnly Periodo { get; set; }

    public decimal Monto { get; set; }

    public string NumeroComprobante { get; set; }

    public string NumeroOperacion { get; set; }

    public DateTime FechaGeneracion { get; set; }

    public CambioEstado CambioEstado { get; set; }
}