namespace Aplicacion.Vecino.Fabrica;

using dominio;

public interface IPropietarioFabrica
{
    Propietario Crear(
        IEnumerable<Propiedad> propiedades,
        tipoVecino tipo,
        string nombres,
        string apellidos,
        bool principal,
        Telefono telefonos,
        DateOnly fechaAdquisicion,
        bool compradorOriginal);
}