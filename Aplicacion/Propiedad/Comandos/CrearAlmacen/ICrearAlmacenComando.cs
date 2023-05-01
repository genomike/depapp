using Aplicacion.Propiedad.Comandos.CrearAlmacen;
namespace Aplicacion.Propiedad.Fabrica;

public interface ICrearAlmacenComando
{
    void Ejecutar(CrearAlmacenModelo modelo);
}