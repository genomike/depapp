using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

public class GetPropiedadDetalles : iGetPropiedadDetalles
{
    iDatabaseService _DatabaseService;

    public GetPropiedadDetalles(iDatabaseService DatabaseService)
    {
        _DatabaseService = _DatabaseService;
    }

    public PropiedadDetallesModel Execute(int Id)
    {
        var departamento = _DatabaseService.Departamentos
                .Where(d => d.Id == Id)
                .Select(d => new PropiedadDetallesModel()
                {
                    Id = d.Id,
                    NombresVecinos = d.Vecino
                                        .Where(vecino => vecino.Principal == true)
                                        .Select(vecino => $"{vecino.Nombres} {vecino.Apellidos}")
                                        .ToList(),
                    TipoPropiedad = d.Tipo.ToString(),
                    Numero = d.Numero,
                    Metraje = d.Metraje,
                    NombreServicios = d.Servicios
                                        .Select(servicio => servicio.Nombre)
                                        .ToList()
                })
                .Single();

        return departamento;
    }
}
