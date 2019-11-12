using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using RelacionaW3.Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Repositorio.Contexto;

namespace Repositorio.Entidades
{
    public class RepositorioPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {
        public RepositorioPessoa(ApplicationDbContext dbContext) : base(dbContext) {
        }   
    }
}
