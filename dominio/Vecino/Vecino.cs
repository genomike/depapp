using dominio.Comun;

namespace dominio;

public abstract class Vecino : iEntidad
{
    public int Id { get; set; }

    public List<Propiedad>? Propiedades { get; set; }

    public tipoVecino Tipo { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public bool Principal { get; set; }

    public Telefono? Telefonos { get; set; }
}