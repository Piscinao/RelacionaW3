using System;
using System.Linq;
using System.Threading.Tasks;
using RelacionaW3.Repositorio.Interfaces;

namespace RelacionaW3.Repositorio.Entidades
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        private readonly Context _contexto;
        // protected DbSet<TEntity> DbSetContext;

        public RepositorioGenerico(Context contexto)
        {
            _contexto = contexto;
            //  DbSetContext = contexto.Set<TEntity>();
        }

        public async Task Update(TEntity entity)
        {
            _contexto.Set<TEntity>().Update(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _contexto.Set<TEntity>().Remove(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task Create(TEntity entity)
        {
            await _contexto.Set<TEntity>().AddAsync(entity);
            await _contexto.SaveChangesAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _contexto.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _contexto.Set<TEntity>();
        }

        public async Task<TEntity> PegarPeloId(int id)
        {
            try
            {
                return await _contexto.Set<TEntity>().FindAsync(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TEntity> PegarPeloId(string id)
        {
            try
            {
                return await _contexto.Set<TEntity>().FindAsync(id);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }



    //    public virtual IEnumerable<TEntity> Read()
    //     {
    //         return DbSetContext.AsNoTracking().ToList();
    //     } 

    //    public virtual IEnumerable<TEntity> Listagem()

    //     {
    //         return DbSetContext.AsNoTracking().ToList();
    //     }

    }
}
