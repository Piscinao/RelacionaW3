using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Entidades
{
    public class AreaRepositorio : RepositorioGenerico<Area>, IAreaRepositorio
    {
        private readonly Context _contexto;

       

        public AreaRepositorio(Context contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public async Task<bool> AreaExiste(string Descricao)
        {
            return await _contexto.Area.AnyAsync(a => a.Descricao == Descricao);
        }

        public async Task<bool> AreaExiste(string Descricao, int Id)
        {
            return await _contexto.Area.AnyAsync(a => a.Descricao == Descricao && a.Id != Id);
        }

         public async Task DeleteArea(int id, string idUsuario)
        {
            //Excluir os id's de resposta que estão na tabela RespostaEventos            
            var listaArea = 
                DbSetContext.Include(x => x.Usuarios)
                .Where(y => y.Id == id).AsNoTracking().ToList();

            AreaResponsavel areaResponsavel;
            foreach (var item in listaArea[0].Usuarios)
            {
                areaResponsavel = new AreaResponsavel();                
                areaResponsavel.IdUsuario = item.IdUsuario;
                areaResponsavel.IdArea = item.IdArea;           

                //delete dos eventos da resposta
                DbSet<AreaResponsavel> DbSetAux;
                DbSetAux = _contexto.Set<AreaResponsavel>();
                DbSetAux.Attach(areaResponsavel);
                DbSetAux.Remove(areaResponsavel);
                _contexto.SaveChanges();
            }
      
            //delete da resposta
            await base.Delete(id);
        }

        
        


        

        

        
    }
}
