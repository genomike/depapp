using dominio;

namespace Aplicacion.Servicio.Fabrica;

internal class AdministracionFabrica : IAdministracionFabrica
{
    public Administracion Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre)
    => new Administracion()
    {
        CostoFijo = costoFijo,
        Fecha = fecha,
        Nombre = nombre
    };
}