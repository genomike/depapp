using dominio.Comun;
using System.ComponentModel.DataAnnotations;

namespace dominio;

public abstract class Vecino : iEntidad
{
    [Required]
    public int Id { get; set; }

    public IEnumerable<Propiedad>? Propiedades { get; set; }

    [Required]
    public tipoVecino Tipo { get; set; }

    [Required]
    public string Nombres { get; set; }

    [Required]
    public string Apellidos { get; set; }

    public bool Principal { get; set; }

    public Telefono? Telefonos { get; set; }
}