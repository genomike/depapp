namespace Aplicacion.Servicio.Consultas.GetServicioLista;

public interface IObtenerMantenimientoLista
{
    IEnumerable<MantenimientoListaModelo>? Ejecutar();
}