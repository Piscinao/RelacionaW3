using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    // Classe abstrata responsável por fazer a comunicação do dbcontext
    // Serve de modelo para produzir novas classes, utiliza para usar o conteúdo como herança
    // Classe abstrata não gera objeto 

    public abstract class Repositorio<TEntidade> : DbContext, IRepositorio<TEntidade>
        where TEntidade : EntityBase, new()
    {
        // Injeção do dbContext
        protected DbContext Db;
        protected DbSet<TEntidade> DbSetContext;

        public Repositorio(DbContext dbContext)
        {
            Db = dbContext;
            // Substitui entidade
            DbSetContext = Db.Set<TEntidade>();
        }

        public void Create(TEntidade Entity)
        {
            if (Entity.Id == null)
            {
                DbSetContext.Add(Entity);
            }
            else
            {
                Db.Entry(Entity).State = EntityState.Modified;
            }

            Db.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var ent = new TEntidade { Id = id };
            DbSetContext.Attach(ent);
            DbSetContext.Remove(ent);
            Db.SaveChanges();
        }

        public TEntidade Read(int id)
        {
            return DbSetContext.Where(x => x.Id == id).FirstOrDefault();
        }

        public virtual IEnumerable<TEntidade> Read()
        {
            return DbSetContext.AsNoTracking().ToList();
        }
    }
}
