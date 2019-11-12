using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Entidades;
using Dominio.Repositorio;
using System.Collections.Generic;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioEvento : Repositorio<Evento>, IRepositorioEvento
    {
        public RepositorioEvento(ApplicationDbContext dbContext) : base(dbContext) {
        }
        public override IEnumerable<Evento> Read()
        {  //Area
            return DbSetContext.Include(x => x.Area).Include(x => x.Pessoa).AsNoTracking().ToList();
           
       }
}
}