using Aplicacion.Interfaces;
using Aplicacion.Propiedad.Fabrica;

namespace Aplicacion.Propiedad.Comandos.CrearDepartamento;

internal class CrearDepartamentoComando : ICrearDepartamentoComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IDepartamentoFabrica _departamentoFabrica;

    public CrearDepartamentoComando(
        iDatabaseService databaseService,
        IDepartamentoFabrica departamentoFabrica)
    {
        _databaseService = databaseService;
        _departamentoFabrica = departamentoFabrica;
    }

    public void Ejecutar(CrearDepartamentoModelo modelo)
    {
        _databaseService.Departamentos.Add(
            _departamentoFabrica.Crear(
                modelo.Vecino,
                modelo.Numero,
                modelo.Metraje,
                modelo.Servicios,
                modelo.Tipo)
            );

        _databaseService.Guardar();
    }
}
