namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

internal interface IObtenerCocheraDetalle
{
    CocheraDetalleModelo? Ejecutar(int Id);
}