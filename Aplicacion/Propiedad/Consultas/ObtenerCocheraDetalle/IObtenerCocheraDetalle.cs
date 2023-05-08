namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

public interface IObtenerCocheraDetalle
{
    CocheraDetalleModelo? Ejecutar(int Id);
}