using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

internal class ObtenerTiendaDetalle : IObtenerTiendaDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerTiendaDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public TiendaDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Tiendas
           .Where(t => t.Id == Id)
           .Select(t => new TiendaDetalleModelo()
           {
               Id = t.Id,
               Vecino = t.Vecino,
               Numero = t.Numero,
               Metraje = t.Metraje,
               Servicios = t.Servicios,
               GiroDeNegocio = t.GiroDeNegocio
           }).Single();
}