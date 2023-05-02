namespace Aplicacion.Servicio.Consultas.GetServicioLista;

internal interface IObtenerMantenimientoLista
{
    IEnumerable<MantenimientoListaModelo>? Ejecutar();
}