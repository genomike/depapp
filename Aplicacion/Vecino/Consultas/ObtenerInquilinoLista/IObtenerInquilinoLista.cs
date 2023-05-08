namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

public interface IObtenerInquilinoLista
{
    IEnumerable<InquilinoListaModelo>? Ejecutar();
}