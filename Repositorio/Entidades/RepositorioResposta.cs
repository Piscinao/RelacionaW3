using Microsoft.EntityFrameworkCore;
using Repositorio.Interfaces;
using RelacionaW3.Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using Repositorio.Contexto;
using System.Linq;

namespace Repositorio.Entidades
{
    public class RepositorioResposta : Repositorio<Resposta>, IRepositorioResposta
    {
        public RepositorioResposta(ApplicationDbContext dbContext) : base(dbContext) {
        }


        public override IEnumerable<Resposta> Read()
        {  //Area
            return DbSetContext.Include(x => x.Eventos).Include(x => x.Pessoa).AsNoTracking().ToList();
           
       }
       
        public override void Delete(int id)
        {
            //Antes precisamos excluir os id's de resposta que estão na tabela RespostaEventos            
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
                DbSetAux = Db.Set<RespostaEventos>();
                DbSetAux.Attach(respostaeventos);
                DbSetAux.Remove(respostaeventos);
                Db.SaveChanges();
            }
      
            //delete da resposta
            base.Delete(id);
        }
    }
}
