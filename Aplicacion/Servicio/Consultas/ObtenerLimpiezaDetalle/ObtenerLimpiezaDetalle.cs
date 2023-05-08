using Aplicacion.Interfaces;
using Aplicacion.Servicio.Consultas.GetServicioDetalles;

namespace Aplicacion.Servicio.Consultas.GetServicioDetails;

internal class ObtenerLimpiezaDetalle : IObtenerLimpiezaDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerLimpiezaDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public LimpiezaDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Limpiezas
           .Where(l => l.Id == Id)
           .Select(l => new LimpiezaDetalleModelo()
           {
               Id = l.Id,
               CostoFijo = l.CostoFijo,
               Fecha = l.Fecha,
               Nombre = l.Nombre,
               GastosInsumos = l.GastosInsumos
           }).Single();
}