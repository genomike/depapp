namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

public interface IObtenerTiendaDetalle
{
    TiendaDetalleModelo? Ejecutar(int Id);
}