namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal interface IObtenerCocheraLista
{
    IEnumerable<CocheraListaModelo>? Ejecutar();
}