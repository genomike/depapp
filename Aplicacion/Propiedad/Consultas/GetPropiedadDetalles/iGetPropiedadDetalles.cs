using Aplicacion.Propiedad.Consultas.GetPropiedadDetalles;

namespace Aplicacion.Propiedad.Consultas.GetPropiedadDetails;

internal interface iGetPropiedadDetalles
{
    PropiedadDetallesModel? Execute(int Id);
}