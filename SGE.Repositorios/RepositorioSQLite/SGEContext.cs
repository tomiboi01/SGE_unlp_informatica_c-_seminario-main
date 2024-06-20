namespace SGE.Repositorios;
using Microsoft.EntityFrameworkCore;
using SGE.Aplicacion;

public class SGEContext : DbContext
{

    public DbSet<Expediente> Expedientes { get; set; }
    public DbSet<Tramite> Tramites { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=sge.sqlite");
    }


}
