using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

public class ObtenerDepartamentoDetalle : IObtenerDepartamentoDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerDepartamentoDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public DepartamentoDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Departamentos
           .Where(d => d.Id == Id)
           .Select(d => new DepartamentoDetalleModelo()
           {
               Id = d.Id,
               Vecino = d.Vecino,
               Numero = d.Numero,
               Metraje = d.Metraje,
               Servicios = d.Servicios
           }).Single();
}