namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public interface IObtenerAlmacenLista
{
    IEnumerable<AlmacenListaModelo>? Ejecutar();
}