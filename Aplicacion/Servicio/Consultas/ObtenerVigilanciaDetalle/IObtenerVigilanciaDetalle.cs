namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

public interface IObtenerVigilanciaDetalle
{
    VigilanciaDetalleModelo? Ejecutar(int Id);
}