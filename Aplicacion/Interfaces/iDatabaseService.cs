using dominio;
using System.Data.Entity;

namespace Aplicacion.Interfaces;

public interface iDatabaseService
{
    // Facturas
    IDbSet<Factura> Facturas { get; set; }

    IDbSet<CambioEstado> CambioEstados { get; set; }

    //Propiedades
    IDbSet<Departamento> Departamentos { get; set; }

    IDbSet<Cochera> Cocheras { get; set; }

    IDbSet<Almacen> Almacenes { get; set; }

    //Servicios
    IDbSet<Servicio> Servicios { get; set; }

    IDbSet<CostoVariable> CostoVariables { get; set; }

    IDbSet<Limpieza> Limpiezas { get; set; }

    IDbSet<Mantenimiento> Mantenimientos { get; set; }

    IDbSet<Vigilancia> Vigilancias { get; set; }

    //Vecinos
    IDbSet<Inquilino> Inquilinos { get; set; }

    IDbSet<Propietario> Propietarios { get; set; }

    IDbSet<Tienda> Tiendas { get; set; }

    IDbSet<Visitante> Visitantes { get; set; }

    void Guardar();
}
