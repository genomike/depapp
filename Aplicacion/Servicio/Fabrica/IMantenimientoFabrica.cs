using dominio;

namespace Aplicacion.Servicio.Fabrica;

public interface IMantenimientoFabrica
{
    Mantenimiento Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre,
        IEnumerable<CostoVariable> gastosMantenimiento,
        string descripcion,
        bool programado);
}