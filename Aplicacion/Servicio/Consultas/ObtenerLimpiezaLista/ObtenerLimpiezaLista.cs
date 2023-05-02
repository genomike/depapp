using Aplicacion.Interfaces;

namespace Aplicacion.Servicio.Consultas.GetServicioLista;

public class ObtenerLimpiezaLista : IObtenerLimpiezaLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerLimpiezaLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public IEnumerable<LimpiezaListaModelo>? Ejecutar()
    => _DatabaseService
        .Limpiezas
        .Select(l => new LimpiezaListaModelo()
        {
            Id = l.Id,
            CostoFijo = l.CostoFijo,
            Fecha = l.Fecha,
            Nombre = l.Nombre,
            GastosInsumos = l.GastosInsumos
        });
}
