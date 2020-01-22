using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Entidades
{
    public class RespostaRepositorio : RepositorioGenerico<Resposta>, IRespostaRepositorio
    {
        private readonly Context _contexto;

       

        public RespostaRepositorio(Context contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public async Task<bool> RespostaExiste(string Descricao)
        {
            return await _contexto.Resposta.AnyAsync(a => a.Descricao == Descricao);
        }

        public async Task<bool> RespostaExiste(string Descricao, int Id)
        {
            return await _contexto.Resposta.AnyAsync(a => a.Descricao == Descricao && a.Id != Id);
        }

       public new async Task<IEnumerable<Resposta>> GetAll()
        {
            return await _contexto.Resposta.Include(e=> e.Pessoa).ToListAsync();
        }


         public async Task<Resposta> RespostaById(int id)
        {
            return await _contexto.Resposta.Include(a => a.Eventos).Include(a => a.Pessoa).Where(a => a.Id == id).FirstAsync();
        }

        // public async Task<IEnumerable<RespostaEventos>> GetAllEventoResposta()
        // {
        //     return await _contexto.RespostaEventos.Include(e=> e.Evento).ToListAsync();
        // }
       
        public async Task DeleteResposta(int id)
        {
            //Excluir os id's de resposta que estão na tabela RespostaEventos            
            var listaEventos = 
                DbSetContext.Include(x => x.Eventos)
                .Where(y => y.Id == id).AsNoTracking().ToList();

            RespostaEventos respostaeventos; 
            foreach (var item in listaEventos[0].Eventos)
            {
                respostaeventos = new RespostaEventos();                
                respostaeventos.IdResposta = id;
                respostaeventos.IdEvento = item.IdEvento;           

                //delete dos eventos da resposta
                DbSet<RespostaEventos> DbSetAux;
                DbSetAux = _contexto.Set<RespostaEventos>();
                DbSetAux.Attach(respostaeventos);
                DbSetAux.Remove(respostaeventos);
                _contexto.SaveChanges();
            }
      
            //delete da resposta
            await base.Delete(id);
        }

        

        
    }
}
