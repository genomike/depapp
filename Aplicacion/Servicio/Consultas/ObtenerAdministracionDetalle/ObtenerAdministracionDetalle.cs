using Aplicacion.Interfaces;
using Aplicacion.Servicio.Consultas.GetServicioDetalles;

namespace Aplicacion.Servicio.Consultas.GetServicioDetails;

public class ObtenerAdministracionDetalle : IObtenerAdministracionDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerAdministracionDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public AdministracionDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Administraciones
           .Where(a => a.Id == Id)
           .Select(a => new AdministracionDetalleModelo()
           {
               Id = a.Id,
               CostoFijo = a.CostoFijo,
               Fecha = a.Fecha,
               Nombre = a.Nombre
           }).Single();
}