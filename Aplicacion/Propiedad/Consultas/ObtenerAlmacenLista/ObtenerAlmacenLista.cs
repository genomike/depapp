using Aplicacion.Interfaces;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public class ObtenerAlmacenLista : IObtenerAlmacenLista
{
    iDatabaseService? _DatabaseService;
    public ObtenerAlmacenLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public IEnumerable<AlmacenListaModelo>? Ejecutar()
    => _DatabaseService
        .Almacenes
        .Select(a => new AlmacenListaModelo()
        {
            Id = a.Id,
            Vecino = a.Vecino,
            Numero = a.Numero,
            Metraje = a.Metraje,
            Servicios = a.Servicios
        });
}