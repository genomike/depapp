﻿using Aplicacion.Interfaces;

namespace Aplicacion.Comprobante.Consultas.ObtenerComprobanteLista;

internal class ObtenerComprobanteLista : IObtenerComprobanteLista
{
    iDatabaseService? _DatabaseService;

    public ObtenerComprobanteLista(iDatabaseService? DatabaseService)
    {
        _DatabaseService = DatabaseService;
    }
    public IEnumerable<ComprobanteListaModelo>? Ejecutar()
    => _DatabaseService?
        .Comprobantes
        .Select(f => new ComprobanteListaModelo()
        {
            Id = f.Id,
            Vecino = f.Vecino,
            Periodo = f.Periodo,
            Monto = f.Monto,
            NumeroComprobante = f.NumeroComprobante,
            NumeroOperacion = f.NumeroOperacion,
            FechaGeneracion = f.FechaGeneracion,
            CambioEstado = f.CambioEstado
        });
}