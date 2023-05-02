namespace Aplicacion.Vecino.Consultas.GetVecinoLista;

internal interface IObtenerInquilinoLista
{
    IEnumerable<InquilinoListaModelo>? Ejecutar();
}