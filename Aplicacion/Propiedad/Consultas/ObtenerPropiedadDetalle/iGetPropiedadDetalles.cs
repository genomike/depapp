namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

internal interface iGetPropiedadDetalles
{
    PropiedadDetallesModel? Execute(int Id);
}