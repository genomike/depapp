namespace Aplicacion.Vecino.Consultas.GetVecinoDetalles;

public interface IObtenerVisitanteDetalle
{
    VisitanteDetalleModelo? Ejecutar(int Id);
}