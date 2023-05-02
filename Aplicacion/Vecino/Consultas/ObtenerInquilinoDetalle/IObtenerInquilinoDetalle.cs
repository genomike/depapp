namespace Aplicacion.Vecino.Consultas.GetVecinoDetalles;

internal interface IObtenerInquilinoDetalle
{
    InquilinoDetalleModelo? Ejecutar(int Id);
}