
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Mapeamentos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionaW3.Repositorio
{
    public class Context : IdentityDbContext <Usuario, NivelAcesso, string>
    {

        public DbSet<Area> Area { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Resposta> Resposta { get; set; }
        public DbSet<AreaResponsavel> AreaResponsavel { get; set; }
        public DbSet<RespostaEventos> RespostaEventos { get; set; }
        public DbSet<NivelAcesso> NivelAcesso { get; set; }

        public Context(DbContextOptions<Context> opcoes) : base(opcoes)
        {

           
        }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new EventoMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new NivelAcessoMap());
            
            modelBuilder.Entity<RespostaEventos>().HasKey(x => new { x.IdResposta, x.IdEvento });

            modelBuilder.Entity<RespostaEventos>()
                .HasOne(x => x.Resposta)
                .WithMany(y => y.Eventos)
                .HasForeignKey(x => x.IdResposta);

            modelBuilder.Entity<RespostaEventos>()
                .HasOne(x => x.Evento)
                .WithMany(y => y.Respostas)
                .HasForeignKey(x => x.IdEvento);

                 modelBuilder.Entity<AreaResponsavel>().HasKey(x => new { x.IdArea, x.IdUsuario });

            modelBuilder.Entity<AreaResponsavel>()
                .HasOne(x => x.Area)
                .WithMany(y => y.Usuarios)
                .HasForeignKey(x => x.IdArea);

            modelBuilder.Entity<AreaResponsavel>()
                .HasOne(x => x.Usuario)
                .WithMany(y => y.Areas)
                .HasForeignKey(x => x.IdUsuario);

           
        }
           
        }

}
