using Aplicacion.Interfaces;
using Aplicacion.Vecino.Consultas.GetVecinoDetalles;

namespace Aplicacion.Vecino.Consultas.GetVecinoDetails;

internal class ObtenerVisitanteDetalle : IObtenerVisitanteDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerVisitanteDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public VisitanteDetalleModelo? Ejecutar(int Id)
            => _DatabaseService?
               .Visitantes
               .Where(v => v.Id == Id)
               .Select(v => new VisitanteDetalleModelo()
               {
                   Id = v.Id,
                   Propiedades = v.Propiedades,
                   Tipo = v.Tipo,
                   Nombres = v.Nombres,
                   Apellidos = v.Apellidos,
                   Principal = v.Principal,
                   Telefonos = v.Telefonos
               }).Single();
}