namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

internal interface IObtenerVisitanteLista
{
    IEnumerable<VisitanteListaModelo>? Ejecutar();
}