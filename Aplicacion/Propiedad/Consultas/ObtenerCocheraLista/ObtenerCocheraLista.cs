using Aplicacion.Interfaces;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal class ObtenerCocheraLista : IObtenerCocheraLista
{
    iDatabaseService? _DatabaseService;
    public ObtenerCocheraLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public IEnumerable<CocheraListaModelo>? Ejecutar()
    => _DatabaseService?
        .Cocheras
        .Select(c => new CocheraListaModelo()
        {
            Id = c.Id,
            Vecino = c.Vecino,
            Numero = c.Numero,
            Metraje = c.Metraje,
            Servicios = c.Servicios
        });
}