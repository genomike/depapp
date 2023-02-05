namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

public class PropiedadDetallesModel
{
    public int Id { get; set; }

    public List<string>? NombresVecinos { get; set; }

    public string? TipoPropiedad { get; set; }

    public string? Numero { get; set; }

    public decimal Metraje { get; set; }

    public List<string>? NombreServicios { get; set; }
}
