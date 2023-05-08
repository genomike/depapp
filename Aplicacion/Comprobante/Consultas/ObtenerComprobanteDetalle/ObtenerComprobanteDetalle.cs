using Aplicacion.Interfaces;

namespace Aplicacion.Comprobante.Consultas.ObtenerComprobanteDetalle;

internal class ObtenerComprobanteDetalle : IObtenerComprobanteDetalle
{
    iDatabaseService? _DatabaseService;

    public ObtenerComprobanteDetalle(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }

    public ComprobanteDetalleModelo? Ejecutar(int Id)
        => _DatabaseService?
           .Comprobantes
           .Where(f => f.Id == Id)
           .Select(f => new ComprobanteDetalleModelo()
           {
               Id = f.Id,
               Vecino = f.Vecino,
               Periodo = f.Periodo,
               Monto = f.Monto,
               NumeroComprobante = f.NumeroComprobante,
               NumeroOperacion = f.NumeroOperacion,
               FechaGeneracion = f.FechaGeneracion,
               CambioEstado = f.CambioEstado
           }).Single();
}