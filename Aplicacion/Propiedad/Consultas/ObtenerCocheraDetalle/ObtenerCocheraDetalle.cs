using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

public class ObtenerCocheraDetalle : IObtenerCocheraDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerCocheraDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public CocheraDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Cocheras
           .Where(c => c.Id == Id)
           .Select(c => new CocheraDetalleModelo()
           {
               Id = c.Id,
               Vecino = c.Vecino,
               Numero = c.Numero,
               Metraje = c.Metraje,
               Servicios = c.Servicios
           }).Single();
}