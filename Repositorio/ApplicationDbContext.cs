using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Repositorio.Contexto
{
    // Teste dbcontext com identity
    public class ApplicationDbContext : IdentityDbContext <IdentityUser>
    {
        public DbSet<Area> Area { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioTeste> UsuarioTeste { get; set; }
        public DbSet<NiveisAcesso> NiveisAcesso { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Resposta> Resposta { get; set; }
        public DbSet<RespostaEventos> RespostaEventos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<RespostaEventos>().HasKey(x => new { x.IdResposta, x.IdEvento });

            builder.Entity<RespostaEventos>()
                .HasOne(x => x.Resposta)
                .WithMany(y => y.Eventos)
                .HasForeignKey(x => x.IdResposta);

            builder.Entity<RespostaEventos>()
                    .HasOne(x => x.Evento)
                    .WithMany(y => y.Respostas)
                    .HasForeignKey(x => x.IdEvento);
        }
    }
}
