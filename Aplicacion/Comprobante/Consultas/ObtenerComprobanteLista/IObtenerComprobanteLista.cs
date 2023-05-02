namespace Aplicacion.Comprobante.Consultas.ObtenerComprobanteLista;

internal interface IObtenerComprobanteLista
{
    IEnumerable<ComprobanteListaModelo>? Ejecutar();
}