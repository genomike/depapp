using Aplicacion.Interfaces;

namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

internal class ObtenerVisitanteLista : IObtenerVisitanteLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerVisitanteLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<VisitanteListaModelo>? Ejecutar()
    => _DatabaseService?
        .Visitantes
        .Select(v => new VisitanteListaModelo()
        {
            Id = v.Id,
            Propiedades = v.Propiedades,
            Tipo = v.Tipo,
            Nombres = v.Nombres,
            Apellidos = v.Apellidos,
            Principal = v.Principal,
            Telefonos = v.Telefonos
        });
}