namespace Aplicacion.Comprobante.Fabrica;

using dominio;

internal class ComprobanteFabrica : IComprobanteFabrica
{
    public Comprobante Crear(
        Vecino vecino,
        DateOnly periodo,
        decimal monto,
        string numeroComprobante,
        string numeroOperacion,
        DateTime fechaGeneracion,
        CambioEstado cambioEstado)
    => new Comprobante()
    {
        Vecino = vecino,
        Periodo = periodo,
        Monto = monto,
        NumeroComprobante = numeroComprobante,
        NumeroOperacion = numeroOperacion,
        FechaGeneracion = fechaGeneracion,
        CambioEstado = cambioEstado
    };
}