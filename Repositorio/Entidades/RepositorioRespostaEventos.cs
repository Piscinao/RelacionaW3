using Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using RelacionaW3.Dominio.DTO;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Entidades
{
    public class RepositorioRespostaEventos : IRepositorioRespostaEventos
    {
        protected ApplicationDbContext DbSetContext;

        public RepositorioRespostaEventos(ApplicationDbContext mContext)
        {
            DbSetContext = mContext;
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            var lista = DbSetContext.RespostaEventos.Include(x=>x.Evento)
                      .GroupBy(x => x.IdEvento)
                      .Select(y => new GraficoViewModel
                      {
                          IdEvento = y.First().IdEvento,
                          Descricao = y.First().Evento.Descricao
                        //   TotalVendido = y.Sum(z => z.Quantidade)
                      }).ToList();

            return lista;
        }
    }
}
