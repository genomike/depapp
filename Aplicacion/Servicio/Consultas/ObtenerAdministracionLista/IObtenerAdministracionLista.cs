namespace Aplicacion.Servicio.Consultas.GetServicioLista;

internal interface IObtenerAdministracionLista
{
    IEnumerable<AdministracionListaModelo>? Ejecutar();
}