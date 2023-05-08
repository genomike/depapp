namespace Aplicacion.Comprobante.Consultas.ObtenerComprobanteLista;

public interface IObtenerComprobanteLista
{
    IEnumerable<ComprobanteListaModelo>? Ejecutar();
}