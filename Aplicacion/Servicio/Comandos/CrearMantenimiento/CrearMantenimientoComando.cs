using Aplicacion.Interfaces;
using Aplicacion.Servicio.Fabrica;

namespace Aplicacion.Servicio.Comandos.CrearMantenimiento;

internal class CrearMantenimientoComando : ICrearMantenimientoComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IMantenimientoFabrica _mantenimientoFabrica;

    public CrearMantenimientoComando(
      iDatabaseService databaseService,
      IMantenimientoFabrica mantenimientoFabrica)
    {
        _databaseService = databaseService;
        _mantenimientoFabrica = mantenimientoFabrica;
    }

    public void Ejecutar(CrearMantenimientoModelo modelo)
    {
        _databaseService.Mantenimientos.Add(
            _mantenimientoFabrica.Crear(
                modelo.CostoFijo,
                modelo.Fecha,
                modelo.Nombre,
                modelo.GastosMantenimiento,
                modelo.Descripcion,
                modelo.Programado)
            );

        _databaseService.Guardar();
    }
}