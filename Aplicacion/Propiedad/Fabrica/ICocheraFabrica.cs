namespace Aplicacion.Propiedad.Fabrica;
using dominio;

public interface ICocheraFabrica
{
    Cochera Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios,
        tipoCochera tipoCochera);
}
