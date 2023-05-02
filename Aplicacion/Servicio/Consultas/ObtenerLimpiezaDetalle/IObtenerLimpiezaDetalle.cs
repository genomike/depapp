namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

internal interface IObtenerLimpiezaDetalle
{
    LimpiezaDetalleModelo? Ejecutar(int Id);
}