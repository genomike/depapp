namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

public interface IObtenerAdministracionDetalle
{
    AdministracionDetalleModelo? Ejecutar(int Id);
}