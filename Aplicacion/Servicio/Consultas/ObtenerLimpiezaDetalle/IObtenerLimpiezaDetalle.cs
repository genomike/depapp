namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

public interface IObtenerLimpiezaDetalle
{
    LimpiezaDetalleModelo? Ejecutar(int Id);
}