namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

internal interface IObtenerDepartamentoLista
{
    IEnumerable<DepartamentoListaModelo>? Ejecutar();
}