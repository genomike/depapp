using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

public class GetPropiedadDetalles : iGetPropiedadDetalles
{
    iDatabaseService? _DatabaseService;

    public GetPropiedadDetalles(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public PropiedadDetallesModel? Execute(int Id)
    {
        var departamento = _DatabaseService?.Departamentos
                .Where(d => d.Id == Id)
                .Select(d => new PropiedadDetallesModel()
                {
                    Id = d.Id,
                    NombresVecinos = ((List<string>)(from v in d.Vecino
                                        where v.Principal == true
                                        select  $"{v.Nombres} {v.Apellidos}")),
                    TipoPropiedad = d.Tipo.ToString(),
                    Numero = d.Numero,
                    Metraje = d.Metraje,
                    NombreServicios = ((List<string>)(from s in d.Servicios select s.Nombre))
                })
                .Single();

        return departamento;
    }
}