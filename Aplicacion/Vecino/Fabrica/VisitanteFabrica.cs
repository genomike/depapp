namespace Aplicacion.Vecino.Fabrica;

using dominio;

internal class VisitanteFabrica : IVisitanteFabrica
{
    public Visitante Crear(
        IEnumerable<Propiedad> propiedades,
        tipoVecino tipo,
        string nombres,
        string apellidos,
        bool principal,
        Telefono telefonos,
        IEnumerable<DateOnly> inicioVisita,
        IEnumerable<DateOnly> terminoVisita)
    => new Visitante()
    {
        Propiedades = propiedades,
        Tipo = tipo,
        Nombres = nombres,
        Apellidos = apellidos,
        Principal = principal,
        Telefonos = telefonos,
        InicioVisita = inicioVisita,
        TerminoVisita = terminoVisita
    };
}