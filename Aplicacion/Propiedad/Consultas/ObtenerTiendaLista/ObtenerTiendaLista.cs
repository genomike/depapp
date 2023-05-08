using Aplicacion.Interfaces;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal class ObtenerTiendaLista : IObtenerTiendaLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerTiendaLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<TiendaListaModelo>? Ejecutar()
    => _DatabaseService?
        .Tiendas
        .Select(t => new TiendaListaModelo()
        {
            Id = t.Id,
            Vecino = t.Vecino,
            Numero = t.Numero,
            Metraje = t.Metraje,
            Servicios = t.Servicios,
            GiroDeNegocio = t.GiroDeNegocio
        });
}