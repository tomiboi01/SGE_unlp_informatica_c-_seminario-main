namespace AL.Repositorios.RepositoriosSQLite;
using SGE.Aplicacion;
using Microsoft.EntityFrameworkCore;
public class SGEContext : DbContext
{
#nullable disable
    public DbSet<Expediente> Expedientes { get; set; }
    public DbSet<Tramite> Tramites { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
#nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=sge.sqlite");
    }


}
