using Aplicacion.Interfaces;
using Aplicacion.Servicio.Fabrica;

namespace Aplicacion.Servicio.Comandos.CrearVigilancia;

internal class CrearVigilanciaComando : ICrearVigilanciaComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IVigilanciaFabrica _vigilanciaFabrica;

    public CrearVigilanciaComando(
       iDatabaseService databaseService,
       IVigilanciaFabrica vigilanciaFabrica)
    {
        _databaseService = databaseService;
        _vigilanciaFabrica = vigilanciaFabrica;
    }

    public void Ejecutar(CrearVigilanciaModelo modelo)
    {
        _databaseService.Vigilancias.Add(
            _vigilanciaFabrica.Crear(
                modelo.CostoFijo,
                modelo.Fecha,
                modelo.Nombre)
            );

        _databaseService.Guardar();
    }
}