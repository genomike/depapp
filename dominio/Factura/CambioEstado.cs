namespace dominio;

public class CambioEstado
{
    public EstadoComprobante EstadoComprobante { get; set; }

    public DateTime FechaCambio { get; set; }

    public string? Notas { get; set; }
}