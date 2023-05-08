namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public interface IObtenerDepartamentoLista
{
    IEnumerable<DepartamentoListaModelo>? Ejecutar();
}