namespace Aplicacion.Servicio.Consultas.GetServicioLista;

public interface IObtenerVigilanciaLista
{
    IEnumerable<VigilanciaListaModelo>? Ejecutar();
}