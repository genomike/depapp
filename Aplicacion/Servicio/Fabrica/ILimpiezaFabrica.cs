using dominio;

namespace Aplicacion.Servicio.Fabrica;

public interface ILimpiezaFabrica
{
    Limpieza Crear(
        decimal costoFijo,
        DateOnly fecha,
        string nombre,
        IEnumerable<CostoVariable> gastosInsumos);
}