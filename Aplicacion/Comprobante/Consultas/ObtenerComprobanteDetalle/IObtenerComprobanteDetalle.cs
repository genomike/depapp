namespace Aplicacion.Comprobante.Consultas.ObtenerComprobanteDetalle;

public interface IObtenerComprobanteDetalle
{
    ComprobanteDetalleModelo? Ejecutar(int Id);
}