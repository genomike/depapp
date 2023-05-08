namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

public interface IObtenerVisitanteLista
{
    IEnumerable<VisitanteListaModelo>? Ejecutar();
}