using Aplicacion.Interfaces;

namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

public class ObtenerInquilinoLista : IObtenerInquilinoLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerInquilinoLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<InquilinoListaModelo>? Ejecutar()
    => _DatabaseService
        .Inquilinos
        .Select(i => new InquilinoListaModelo()
        {
            Id = i.Id,
            Propiedades = i.Propiedades,
            Tipo = i.Tipo,
            Nombres = i.Nombres,
            Apellidos = i.Apellidos,
            Principal = i.Principal,
            Telefonos = i.Telefonos,
            Nacionalidad = i.Nacionalidad
        });
}