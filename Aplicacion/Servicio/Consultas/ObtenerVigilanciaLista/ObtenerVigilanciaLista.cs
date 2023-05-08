using Aplicacion.Interfaces;

namespace Aplicacion.Servicio.Consultas.GetServicioLista;

internal class ObtenerVigilanciaLista : IObtenerVigilanciaLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerVigilanciaLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<VigilanciaListaModelo>? Ejecutar()
    => _DatabaseService
        .Vigilancias
        .Select(v => new VigilanciaListaModelo()
        {
            Id = v.Id,
            CostoFijo = v.CostoFijo,
            Fecha = v.Fecha,
            Nombre = v.Nombre
        });
}