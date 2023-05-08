namespace Aplicacion.Vecino.Consultas.GetVecinoDetalles;

public interface IObtenerInquilinoDetalle
{
    InquilinoDetalleModelo? Ejecutar(int Id);
}