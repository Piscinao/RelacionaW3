using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio;

namespace RelacionaW3.Repositorio
{
    public class RelacionaW3Context : DbContext


    {
        public RelacionaW3Context(DbContextOptions<RelacionaW3Context> options): base(options) {}
        
        public DbSet<Evento> Eventos {get; set;}

        public DbSet<Palestrante> Palestrantes {get; set;}

        public DbSet<PalestranteEvento> PalestranteEventos {get; set;}

        public DbSet<Lote> Lotes {get; set;}

        public DbSet<RedeSocial> RedeSociais {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<PalestranteEvento>()
         .HasKey(PE => new {PE.EventoId, PE.PalestranteId});
    }
    }
}