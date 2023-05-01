using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Fabrica;

namespace Aplicacion.Propiedad.Comandos.CrearAlmacen;

internal class CrearAlmacenComando : ICrearAlmacenComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IAlmacenFabrica _almacenFabrica;

    public CrearAlmacenComando(
        iDatabaseService databaseService,
        IAlmacenFabrica almacenFabrica)
    {
        _databaseService = databaseService;
        _almacenFabrica = almacenFabrica;
    }

    public void Ejecutar(CrearAlmacenModelo modelo)
    {
        _databaseService.Almacenes.Add(
            _almacenFabrica.Crear(
                modelo.Vecino,
                modelo.Numero,
                modelo.Metraje,
                modelo.Servicios)
            );

        _databaseService.Guardar();
    }
}