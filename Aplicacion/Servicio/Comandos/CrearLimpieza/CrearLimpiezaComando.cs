using Aplicacion.Interfaces;
using Aplicacion.Servicio.Fabrica;

namespace Aplicacion.Servicio.Comandos.CrearLimpieza;

internal class CrearLimpiezaComando : ICrearLimpiezaComando
{
    private readonly iDatabaseService _databaseService;
    private readonly ILimpiezaFabrica _limpiezaFabrica;

    public CrearLimpiezaComando(
       iDatabaseService databaseService,
       ILimpiezaFabrica limpiezaFabrica)
    {
        _databaseService = databaseService;
        _limpiezaFabrica = limpiezaFabrica;
    }

    public void Ejecutar(CrearLimpiezaModelo modelo)
    {
        _databaseService.Limpiezas.Add(
            _limpiezaFabrica.Crear(
                modelo.CostoFijo,
                modelo.Fecha,
                modelo.Nombre,
                modelo.GastosInsumos)
            );

        _databaseService.Guardar();
    }
}