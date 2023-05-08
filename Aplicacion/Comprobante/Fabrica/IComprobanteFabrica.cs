namespace Aplicacion.Comprobante.Fabrica;

using dominio;

public interface IComprobanteFabrica
{
    Comprobante Crear(
        Vecino vecino,
        DateOnly periodo,
        decimal monto,
        string numeroComprobante,
        string numeroOperacion,
        DateTime fechaGeneracion,
        CambioEstado cambioEstado);
}