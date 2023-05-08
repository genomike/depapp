namespace Aplicacion.Vecino.Fabrica;

using dominio;

public interface IVisitanteFabrica
{
    Visitante Crear(
        IEnumerable<Propiedad> propiedades,
        tipoVecino tipo,
        string nombres,
        string apellidos,
        bool principal,
        Telefono telefonos,
        IEnumerable<DateOnly> inicioVisita,
        IEnumerable<DateOnly> terminoVisita);
}