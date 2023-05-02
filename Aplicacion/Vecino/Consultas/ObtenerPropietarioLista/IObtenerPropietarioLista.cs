namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

internal interface IObtenerPropietarioLista
{
    IEnumerable<PropietarioListaModelo>? Ejecutar();
}