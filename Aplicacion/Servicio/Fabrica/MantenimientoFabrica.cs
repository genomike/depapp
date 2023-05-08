using dominio;

namespace Aplicacion.Servicio.Fabrica;

internal class MantenimientoFabrica : IMantenimientoFabrica
{
    public Mantenimiento Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre,
        IEnumerable<CostoVariable> gastosMantenimiento,
        string descripcion,
        bool programado)
    => new Mantenimiento()
    {
        CostoFijo = costoFijo,
        Fecha = fecha,
        Nombre = nombre,
        GastosMantenimiento = gastosMantenimiento,
        Descripcion = descripcion,
        Programado = programado
    };
}