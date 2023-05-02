namespace Aplicacion.Servicio.Consultas.GetServicioDetalles;

internal interface IObtenerVigilanciaDetalle
{
    VigilanciaDetalleModelo? Ejecutar(int Id);
}