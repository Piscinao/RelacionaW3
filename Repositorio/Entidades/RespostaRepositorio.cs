using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Collections.Generic;
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
       
        // public override void Delete(int id)
        // {
        //     //Antes precisamos excluir os id's de resposta que estão na tabela RespostaEventos            
        //     var listaEventos = 
        //         DbSetContext.Include(x => x.Eventos)
        //         .Where(y => y.Id == id).AsNoTracking().ToList();

        //     RespostaEventos respostaeventos;
        //     foreach (var item in listaEventos[0].Eventos)
        //     {
        //         respostaeventos = new RespostaEventos();                
        //         respostaeventos.IdResposta = id;
        //         respostaeventos.IdEvento = item.IdEvento;           

        //         //delete dos eventos da resposta
        //         DbSet<RespostaEventos> DbSetAux;
        //         DbSetAux = Db.Set<RespostaEventos>();
        //         DbSetAux.Attach(respostaeventos);
        //         DbSetAux.Remove(respostaeventos);
        //         Db.SaveChanges();
        //     }
      
        //     //delete da resposta
        //     base.Delete(id);
        // }

        

        
    }
}
