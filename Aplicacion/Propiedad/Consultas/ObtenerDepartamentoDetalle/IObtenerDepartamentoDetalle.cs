namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

internal interface IObtenerDepartamentoDetalle
{
    DepartamentoDetalleModelo? Ejecutar(int Id);
}