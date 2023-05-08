using dominio;

namespace Aplicacion.Servicio.Fabrica;

internal class VigilanciaFabrica : IVigilanciaFabrica
{
    public Vigilancia Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre)
    => new Vigilancia()
    {
        CostoFijo = costoFijo,
        Fecha = fecha,
        Nombre = nombre
    };
}