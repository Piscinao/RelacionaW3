
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RelacionaW3.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionaW3.Repositorio.Mapeamentos
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasMaxLength(50).IsRequired();
            // builder.Property(p => p.Turno).HasMaxLength(15).IsRequired();
            builder.Property(p => p.Email);  
            builder.Property(p => p.CPF);
            builder.Property(p => p.CNPJ);
            builder.Property(p => p.Celular);
            builder.Property(p => p.Classificacao);
            builder.Property(p => p.Empresa);
            builder.Property(p => p.Telefone);

            
           

            builder.ToTable("Pessoa");
        }
    }
}
