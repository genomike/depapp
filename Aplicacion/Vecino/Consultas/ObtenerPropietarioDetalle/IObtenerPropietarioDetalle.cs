namespace Aplicacion.Vecino.Consultas.GetVecinoDetalles;

public interface IObtenerPropietarioDetalle
{
    PropietarioDetalleModelo? Ejecutar(int Id);
}