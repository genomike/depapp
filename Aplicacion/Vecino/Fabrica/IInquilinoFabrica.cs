namespace Aplicacion.Vecino.Fabrica;

using dominio;

public interface IInquilinoFabrica
{
    Inquilino Crear(
        IEnumerable<Propiedad> propiedades,
        tipoVecino tipo,
        string nombres,
        string apellidos,
        bool principal,
        Telefono telefonos,
        Nacionalidad nacionalidad);
}