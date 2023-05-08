namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

public interface IObtenerPropietarioLista
{
    IEnumerable<PropietarioListaModelo>? Ejecutar();
}