using Aplicacion.Interfaces;

namespace Aplicacion.Servicio.Consultas.GetServicioLista;

internal class ObtenerMantenimientoLista : IObtenerMantenimientoLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerMantenimientoLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<MantenimientoListaModelo>? Ejecutar()
    => _DatabaseService
        .Mantenimientos
        .Select(m => new MantenimientoListaModelo()
        {
            Id = m.Id,
            CostoFijo = m.CostoFijo,
            Fecha = m.Fecha,
            Nombre = m.Nombre,
            GastosMantenimiento = m.GastosMantenimiento,
            Descripcion = m.Descripcion,
            Programado = m.Programado
        });
}