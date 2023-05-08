namespace Aplicacion.Vecino.Fabrica;

using dominio;

internal class InquilinoFabrica : IInquilinoFabrica
{
    public Inquilino Crear(
         IEnumerable<Propiedad> propiedades,
         tipoVecino tipo,
         string nombres,
         string apellidos,
         bool principal,
         Telefono telefonos,
         Nacionalidad nacionalidad)
     => new Inquilino()
     {
         Propiedades = propiedades,
         Tipo = tipo,
         Nombres = nombres,
         Apellidos = apellidos,
         Principal = principal,
         Telefonos = telefonos,
         Nacionalidad = nacionalidad
     };
}