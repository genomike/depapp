namespace Aplicacion.Vecino.Consultas.GetVecinoDetalles;

internal interface IObtenerPropietarioDetalle
{
    PropietarioDetalleModelo? Ejecutar(int Id);
}