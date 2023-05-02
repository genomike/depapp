namespace Aplicacion.Servicio.Consultas.GetServicioLista;

internal interface IObtenerVigilanciaLista
{
    IEnumerable<VigilanciaListaModelo>? Ejecutar();
}