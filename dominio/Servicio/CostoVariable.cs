namespace dominio;

public class CostoVariable
{
    public DateOnly FechaGasto { get; set; }

    public decimal Costo { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }
}