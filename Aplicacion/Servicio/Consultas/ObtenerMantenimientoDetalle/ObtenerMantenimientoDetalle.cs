using Aplicacion.Interfaces;
using Aplicacion.Servicio.Consultas.GetServicioDetalles;

namespace Aplicacion.Servicio.Consultas.GetServicioDetails;

internal class ObtenerMantenimientoDetalle : IObtenerMantenimientoDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerMantenimientoDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public MantenimientoDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Mantenimientos
           .Where(m => m.Id == Id)
           .Select(m => new MantenimientoDetalleModelo()
           {
               Id = m.Id,
               CostoFijo = m.CostoFijo,
               Fecha = m.Fecha,
               Nombre = m.Nombre,
               GastosMantenimiento = m.GastosMantenimiento,
               Descripcion = m.Descripcion,
               Programado = m.Programado
           }).Single();
}
