using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Comandos.CrearDepartamento;
using Aplicacion.Propiedad.Fabrica;

namespace Aplicacion.Propiedad.Comandos.CrearCochera;

internal class CrearCocheraComando : ICrearCocheraComando
{
    private readonly iDatabaseService _databaseService;
    private readonly ICocheraFabrica _cocheraFabrica;

    public CrearCocheraComando(
        iDatabaseService databaseService,
        ICocheraFabrica cocheraFabrica)
    {
        _databaseService = databaseService;
        _cocheraFabrica = cocheraFabrica;
    }

    public void Ejecutar(CrearCocheraModelo modelo)
    {
        _databaseService.Cocheras.Add(
            _cocheraFabrica.Crear(
                modelo.Vecino,
                modelo.Numero,
                modelo.Metraje,
                modelo.Servicios,
                modelo.Tipo)
            );

        _databaseService.Guardar();
    }
}
