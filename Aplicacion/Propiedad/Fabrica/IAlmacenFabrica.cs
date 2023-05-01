using dominio;
namespace Aplicacion.Propiedad.Fabrica;

public interface IAlmacenFabrica
{
    Almacen Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios);
}