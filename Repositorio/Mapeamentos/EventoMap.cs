
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelacionaW3.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionaW3.Repositorio.Mapeamentos
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(p => p.Id);

            // builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
            // builder.Property(p => p.Turno).HasMaxLength(15).IsRequired();
        
           
            builder.HasOne(a => a.Pessoa).WithMany(a => a.Eventos).HasForeignKey(a => a.IdPessoa);
            builder.HasOne(a => a.Area).WithMany(a => a.Eventos).HasForeignKey(a => a.IdArea);
            
            // builder.HasOne(a => a.Usuario).WithMany(a => a.Eventos).HasForeignKey(a => a.IdUsuario);
            // builder.HasMany(e => e.ListaExercicios).WithOne(e => e.Exercicio);
           

            // builder.HasMany(p => p.Alunos).WithOne(p => p.Professor);

            builder.ToTable("Evento");
        }
    }
}
