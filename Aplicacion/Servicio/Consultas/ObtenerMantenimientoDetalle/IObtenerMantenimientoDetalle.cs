namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

internal interface IObtenerMantenimientoDetalle
{
    MantenimientoDetalleModelo? Ejecutar(int Id);
}