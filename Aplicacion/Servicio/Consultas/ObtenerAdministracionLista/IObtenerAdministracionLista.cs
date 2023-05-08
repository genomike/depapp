namespace Aplicacion.Servicio.Consultas.GetServicioLista;

public interface IObtenerAdministracionLista
{
    IEnumerable<AdministracionListaModelo>? Ejecutar();
}