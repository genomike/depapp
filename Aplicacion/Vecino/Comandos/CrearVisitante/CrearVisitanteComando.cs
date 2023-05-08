using Aplicacion.Interfaces;
using Aplicacion.Vecino.Fabrica;

namespace Aplicacion.Vecino.Comandos.CrearVisitante;

internal class CrearVisitanteComando : ICrearVisitanteComando
{
    private readonly iDatabaseService _databaseService;
    private readonly IVisitanteFabrica _visitanteFabrica;

    public CrearVisitanteComando(
       iDatabaseService databaseService,
       IVisitanteFabrica visitanteFabrica)
    {
        _databaseService = databaseService;
        _visitanteFabrica = visitanteFabrica;
    }

    public void Ejecutar(CrearVisitanteModelo modelo)
    {
        _databaseService.Visitantes.Add(
            _visitanteFabrica.Crear(
                modelo.Propiedades,
                modelo.Tipo,
                modelo.Nombres,
                modelo.Apellidos,
                modelo.Principal,
                modelo.Telefonos,
                modelo.InicioVisita,
                modelo.TerminoVisita)
            );

        _databaseService.Guardar();
    }
}