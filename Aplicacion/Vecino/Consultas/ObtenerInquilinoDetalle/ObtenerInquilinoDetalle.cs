using Aplicacion.Interfaces;
using Aplicacion.Vecino.Consultas.GetVecinoDetalles;

namespace Aplicacion.Vecino.Consultas.GetVecinoDetails;

public class ObtenerInquilinoDetalle : IObtenerInquilinoDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerInquilinoDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public InquilinoDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Inquilinos
           .Where(i => i.Id == Id)
           .Select(i => new InquilinoDetalleModelo()
           {
               Id = i.Id,
               Propiedades = i.Propiedades,
               Tipo = i.Tipo,
               Nombres = i.Nombres,
               Apellidos = i.Apellidos,
               Principal = i.Principal,
               Telefonos = i.Telefonos,
               Nacionalidad = i.Nacionalidad
           }).Single();
}