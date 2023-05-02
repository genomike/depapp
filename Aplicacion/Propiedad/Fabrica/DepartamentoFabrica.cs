namespace Aplicacion.Propiedad.Fabrica;

using dominio;

internal class DepartamentoFabrica : IDepartamentoFabrica
{
    public Departamento Crear(
        IEnumerable<Vecino> vecinos,
        string numero,
        decimal metraje,
        IEnumerable<Servicio> servicios,
        tipoDepartamento tipoDepartamento)
        => new Departamento()
        {
            Vecino = vecinos,
            Numero = numero,
            Metraje = metraje,
            Servicios = servicios,
            Tipo = tipoDepartamento
        };
}
