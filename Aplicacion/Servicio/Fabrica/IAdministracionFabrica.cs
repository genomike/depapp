using dominio;

namespace Aplicacion.Servicio.Fabrica;

public interface IAdministracionFabrica
{
    Administracion Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre);
}