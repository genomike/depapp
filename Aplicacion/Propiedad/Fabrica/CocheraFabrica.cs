namespace Aplicacion.Propiedad.Fabrica;
using dominio;

internal class CocheraFabrica : ICocheraFabrica
{
    public Cochera Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios,
        tipoCochera tipoCochera)
        => new Cochera()
        {
            Vecino = vecinos,
            Numero = numero,
            Metraje = metraje,
            Servicios = servicios,
            Tipo = tipoCochera
        };
}
