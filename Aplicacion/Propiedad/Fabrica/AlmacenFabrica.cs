namespace Aplicacion.Propiedad.Fabrica;
using dominio;

internal class AlmacenFabrica : IAlmacenFabrica
{
    public Almacen Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios)
        => new Almacen()
        {
            Vecino = vecinos,
            Numero = numero,
            Metraje = metraje,
            Servicios = servicios
        };
}