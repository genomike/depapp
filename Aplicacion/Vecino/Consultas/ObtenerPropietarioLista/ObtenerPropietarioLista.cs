using Aplicacion.Interfaces;

namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

internal class ObtenerPropietarioLista : IObtenerPropietarioLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerPropietarioLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<PropietarioListaModelo>? Ejecutar()
        => _DatabaseService
            .Propietarios
            .Select(p => new PropietarioListaModelo()
            {
                Id = p.Id,
                Propiedades = p.Propiedades,
                Tipo = p.Tipo,
                Nombres = p.Nombres,
                Apellidos = p.Apellidos,
                Principal = p.Principal,
                Telefonos = p.Telefonos,
                fechaAdquisicion = p.fechaAdquisicion,
                compradorOriginal = p.compradorOriginal
            });
}