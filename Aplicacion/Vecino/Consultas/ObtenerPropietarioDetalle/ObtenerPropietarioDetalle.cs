using Aplicacion.Interfaces;
using Aplicacion.Vecino.Consultas.GetVecinoDetalles;

namespace Aplicacion.Vecino.Consultas.GetVecinoDetails;

public class ObtenerPropietarioDetalle : IObtenerPropietarioDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerPropietarioDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public PropietarioDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Propietarios
           .Where(p => p.Id == Id)
           .Select(p => new PropietarioDetalleModelo()
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
           }).Single();
}