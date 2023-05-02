namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

internal interface IObtenerTiendaDetalle
{
    TiendaDetalleModelo? Ejecutar(int Id);
}