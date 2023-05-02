namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

internal interface IObtenerAlmacenDetalle
{
    AlmacenDetalleModelo? Ejecutar(int Id);
}