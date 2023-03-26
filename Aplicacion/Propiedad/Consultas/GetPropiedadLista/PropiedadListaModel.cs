namespace Aplicacion.Propiedad.Consultas.GetPropiedadLista;

public class PropiedadListaModel
{
    public int Id { get; set; }

    public List<string>? NombresVecinos { get; set; }

    public string? TipoPropiedad { get; set; }

    public string? Numero { get; set; }

    public decimal Metraje { get; set; }

    public List<string>? NombreServicios { get; set; }
}
