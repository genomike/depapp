using Aplicacion.Interfaces;
using Aplicacion.Servicio.Fabrica;

namespace Aplicacion.Servicio.Comandos.CrearAdministracion;

internal class CrearAdministracionComando : ICrearAdministracionComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IAdministracionFabrica _administracionFabrica;

    public CrearAdministracionComando(
       iDatabaseService databaseService,
       IAdministracionFabrica administracionFabrica)
    {
        _databaseService = databaseService;
        _administracionFabrica = administracionFabrica;
    }

    public void Ejecutar(CrearAdministracionModelo modelo)
    {
        _databaseService.Administraciones.Add(
            _administracionFabrica.Crear(
                modelo.CostoFijo,
                modelo.Fecha,
                modelo.Nombre)
            );

        _databaseService.Guardar();
    }
}