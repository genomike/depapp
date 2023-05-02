namespace Aplicacion.Servicio.Consultas.GetServicioLista;

internal interface IObtenerLimpiezaLista
{
    IEnumerable<LimpiezaListaModelo>? Ejecutar();
}