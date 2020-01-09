using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IRepositorioGenerico<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);

        // Task<TEntity> GetAreaById(int IdArea, string IdUsuario);
        // IEnumerable<TEntity> Listagem();
        Task Create(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
        Task<TEntity> PegarPeloId(int id);
        Task<TEntity> PegarPeloId(string id);
       
    }
}
