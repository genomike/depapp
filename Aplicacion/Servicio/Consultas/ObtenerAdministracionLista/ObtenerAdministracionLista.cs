using Aplicacion.Interfaces;

namespace Aplicacion.Servicio.Consultas.GetServicioLista;

public class ObtenerAdministracionLista : IObtenerAdministracionLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerAdministracionLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public IEnumerable<AdministracionListaModelo>? Ejecutar()
    => _DatabaseService
        .Administraciones
        .Select(a => new AdministracionListaModelo()
        {
            Id = a.Id,
            CostoFijo = a.CostoFijo,
            Fecha = a.Fecha,
            Nombre = a.Nombre
        });
}