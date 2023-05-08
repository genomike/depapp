namespace Aplicacion.Servicio.Consultas.GetServicioLista;

public interface IObtenerLimpiezaLista
{
    IEnumerable<LimpiezaListaModelo>? Ejecutar();
}