namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public interface IObtenerTiendaLista
{
    IEnumerable<TiendaListaModelo>? Ejecutar();
}