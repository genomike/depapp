namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal interface IObtenerTiendaLista
{
    IEnumerable<TiendaListaModelo>? Ejecutar();
}