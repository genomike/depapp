using Aplicacion.Interfaces;
namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public class GetPropiedadLista : iGetPropiedadLista
{
    iDatabaseService? _DatabaseService;

    public GetPropiedadLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public List<PropiedadListaModel>? Execute()
    {
        var departamentos = _DatabaseService?.Departamentos
            .Select(d => new PropiedadListaModel()
            {
                Id = d.Id,
                NombresVecinos = ((List<string>)(from v in d.Vecino
                                                 where v.Principal == true
                                                 select $"{v.Nombres} {v.Apellidos}")),
                TipoPropiedad = d.Tipo.ToString(),
                Numero = d.Numero,
                Metraje = d.Metraje,
                NombreServicios = ((List<string>)(from s in d.Servicios select s.Nombre))
            });

        return departamentos?.ToList();
    }
}
