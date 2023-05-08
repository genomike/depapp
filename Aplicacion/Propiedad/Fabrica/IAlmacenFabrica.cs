namespace Aplicacion.Propiedad.Fabrica;

using dominio;

public interface IAlmacenFabrica
{
    Almacen Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios);
}