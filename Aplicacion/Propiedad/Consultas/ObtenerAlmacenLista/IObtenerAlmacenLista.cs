namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal interface IObtenerAlmacenLista
{
    IEnumerable<AlmacenListaModelo>? Ejecutar();
}