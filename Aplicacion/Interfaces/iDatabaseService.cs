using dominio;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Interfaces;

public interface iDatabaseService
{
    DbSet<Departamento> Departamentos { get; set; }

    void Guardar();
}
