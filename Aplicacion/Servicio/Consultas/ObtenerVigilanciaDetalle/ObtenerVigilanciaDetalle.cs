using Aplicacion.Interfaces;
using Aplicacion.Servicio.Consultas.GetServicioDetalles;

namespace Aplicacion.Servicio.Consultas.GetServicioDetails;

internal class ObtenerVigilanciaDetalle : IObtenerVigilanciaDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerVigilanciaDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public VigilanciaDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Vigilancias
           .Where(v => v.Id == Id)
           .Select(v => new VigilanciaDetalleModelo()
           {
               Id = v.Id,
               CostoFijo = v.CostoFijo,
               Fecha = v.Fecha,
               Nombre = v.Nombre
           }).Single();
}