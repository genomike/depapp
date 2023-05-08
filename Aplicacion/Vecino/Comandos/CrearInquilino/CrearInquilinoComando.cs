using Aplicacion.Interfaces;
using Aplicacion.Vecino.Fabrica;

namespace Aplicacion.Vecino.Comandos.CrearInquilino;

internal class CrearInquilinoComando : ICrearInquilinoComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IInquilinoFabrica _inquilinoFabrica;

    public CrearInquilinoComando(
       iDatabaseService databaseService,
       IInquilinoFabrica inquilinoFabrica)
    {
        _databaseService = databaseService;
        _inquilinoFabrica = inquilinoFabrica;
    }
    public void Ejecutar(CrearInquilinoModelo modelo)
    {
        _databaseService.Inquilinos.Add(
            _inquilinoFabrica.Crear(
                modelo.Propiedades,
                modelo.Tipo,
                modelo.Nombres,
                modelo.Apellidos,
                modelo.Principal,
                modelo.Telefonos,
                modelo.Nacionalidad)
            );

        _databaseService.Guardar();
    }
}
