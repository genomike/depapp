using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

internal class ObtenerAlmacenDetalle : IObtenerAlmacenDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerAlmacenDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public AlmacenDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Almacenes
           .Where(a => a.Id == Id)
           .Select(a => new AlmacenDetalleModelo()
           {
               Id = a.Id,
               Vecino = a.Vecino,
               Numero = a.Numero,
               Metraje = a.Metraje,
               Servicios = a.Servicios
           }).Single();
}