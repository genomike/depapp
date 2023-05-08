namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

public interface IObtenerAlmacenDetalle
{
    AlmacenDetalleModelo? Ejecutar(int Id);
}