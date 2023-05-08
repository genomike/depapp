namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

public interface IObtenerDepartamentoDetalle
{
    DepartamentoDetalleModelo? Ejecutar(int Id);
}