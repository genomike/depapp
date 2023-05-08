using dominio;

namespace Aplicacion.Servicio.Fabrica;

internal class LimpiezaFabrica : ILimpiezaFabrica
{
    public Limpieza Crear(
         decimal costoFijo,
         DateOnly fecha,
         string nombre,
         IEnumerable<CostoVariable> gastosInsumos)
     => new Limpieza()
     {
         CostoFijo = costoFijo,
         Fecha = fecha,
         Nombre = nombre,
         GastosInsumos = gastosInsumos
     };
}