using Aplicacion.Interfaces;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal class ObtenerDepartamentoLista : IObtenerDepartamentoLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerDepartamentoLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public IEnumerable<DepartamentoListaModelo>? Ejecutar()
    => _DatabaseService
        .Departamentos
        .Select(d => new DepartamentoListaModelo()
        {
            Id = d.Id,
            Vecino = d.Vecino,
            Numero = d.Numero,
            Metraje = d.Metraje,
            Servicios = d.Servicios
        });
}
