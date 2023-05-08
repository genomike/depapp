namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

public interface IObtenerMantenimientoDetalle
{
    MantenimientoDetalleModelo? Ejecutar(int Id);
}