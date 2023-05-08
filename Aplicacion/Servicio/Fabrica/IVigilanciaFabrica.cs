using dominio;

namespace Aplicacion.Servicio.Fabrica;

public interface IVigilanciaFabrica
{
    Vigilancia Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre);
}