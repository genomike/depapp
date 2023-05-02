namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

internal interface IObtenerAdministracionDetalle
{
    AdministracionDetalleModelo? Ejecutar(int Id);
}