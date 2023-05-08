using Aplicacion.Interfaces;
using Aplicacion.Vecino.Fabrica;

namespace Aplicacion.Vecino.Comandos.CrearPropietario;

internal class CrearPropietarioComando : ICrearPropietarioComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IPropietarioFabrica _propietarioFabrica;

    public CrearPropietarioComando(
        iDatabaseService databaseService,
        IPropietarioFabrica propietarioFabrica)
    {
        _databaseService = databaseService;
        _propietarioFabrica = propietarioFabrica;
    }
    public void Ejecutar(CrearPropietarioModelo modelo)
    {
        _databaseService.Propietarios.Add(
            _propietarioFabrica.Crear(
                modelo.Propiedades,
                modelo.Tipo,
                modelo.Nombres,
                modelo.Apellidos,
                modelo.Principal,
                modelo.Telefonos,
                modelo.fechaAdquisicion,
                modelo.compradorOriginal)
            );

        _databaseService.Guardar();
    }
}