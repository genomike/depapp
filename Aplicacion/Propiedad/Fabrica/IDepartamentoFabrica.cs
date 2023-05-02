namespace Aplicacion.Propiedad.Fabrica;

using dominio;

public interface IDepartamentoFabrica
{
    Departamento Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios,
        tipoDepartamento tipoDepartamento);
}
