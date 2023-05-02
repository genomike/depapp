namespace Aplicacion.Vecino.Consultas.GetVecinoDetalles;

internal interface IObtenerVisitanteDetalle
{
    VisitanteDetalleModelo? Ejecutar(int Id);
}