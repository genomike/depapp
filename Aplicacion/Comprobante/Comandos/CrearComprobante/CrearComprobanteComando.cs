using Aplicacion.Comprobante.Fabrica;
using Aplicacion.Interfaces;

namespace Aplicacion.Comprobante.Comandos.CrearComprobante;

internal class CrearComprobanteComando : ICrearComprobanteComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IComprobanteFabrica _comprobanteFabrica;

    public CrearComprobanteComando(
       iDatabaseService databaseService,
       IComprobanteFabrica comprobanteFabrica)
    {
        _databaseService = databaseService;
        _comprobanteFabrica = comprobanteFabrica;
    }

    public void Ejecutar(CrearComprobanteModelo modelo)
    {
        _databaseService.Comprobantes.Add(
            _comprobanteFabrica.Crear(
                modelo.Vecino,
                modelo.Periodo,
                modelo.Monto,
                modelo.NumeroComprobante,
                modelo.NumeroOperacion,
                modelo.FechaGeneracion,
                modelo.CambioEstado)
            );

        _databaseService.Guardar();
    }
}