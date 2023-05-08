namespace Aplicacion.Vecino.Fabrica;

using dominio;

internal class PropietarioFabrica : IPropietarioFabrica
{
    public Propietario Crear(
        IEnumerable<Propiedad> propiedades,
        tipoVecino tipo,
        string nombres,
        string apellidos,
        bool principal,
        Telefono telefonos,
        DateOnly fechaAdquisicion,
        bool compradorOriginal)
    => new Propietario()
    {
        Propiedades = propiedades,
        Tipo = tipo,
        Nombres = nombres,
        Apellidos = apellidos,
        Principal = principal,
        Telefonos = telefonos,
        fechaAdquisicion = fechaAdquisicion,
        compradorOriginal = compradorOriginal
    };
}