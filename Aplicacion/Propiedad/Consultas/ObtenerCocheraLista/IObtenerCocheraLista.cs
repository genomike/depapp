namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public interface IObtenerCocheraLista
{
    IEnumerable<CocheraListaModelo>? Ejecutar();
}