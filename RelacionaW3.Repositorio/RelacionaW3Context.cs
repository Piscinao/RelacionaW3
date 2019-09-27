using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio;
using RelacionaW3.Dominio.Identity;
using System.Collections.Generic;

namespace RelacionaW3.Repositorio
{
    public class RelacionaW3Context : IdentityDbContext<User, Role, int,
                                                        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
                                                        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public RelacionaW3Context(DbContextOptions<RelacionaW3Context> options): base(options) {}
        
        public DbSet<Evento> Eventos {get; set;}

        public DbSet<Palestrante> Palestrantes {get; set;}

        public DbSet<User> AspNetUsers {get; }

        public DbSet<Area> Areas {get; set;}

        public DbSet<PalestranteEvento> PalestranteEventos {get; set;}

        public DbSet<Lote> Lotes {get; set;}

        public DbSet<RedeSocial> RedeSociais {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new {ur.UserId, ur.RoleId});

                userRole.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

                 userRole.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();

            }
        );
         modelBuilder.Entity<PalestranteEvento>()
         .HasKey(PE => new {PE.EventoId, PE.PalestranteId});
    }
    }
}