using Aplicacao.Servico.Interfaces;
using Dominio.Interfaces;
using Newtonsoft.Json;
using RelacionaW3.Dominio.Entidades;
using RelacionaW3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoResposta : IServicoAplicacaoResposta
    {
        private readonly IServicoResposta ServicoResposta;

        public ServicoAplicacaoResposta(IServicoResposta servicoResposta)
        {
            ServicoResposta = servicoResposta;
        }

        public void Create(RespostaViewModel resposta)
        {
            Resposta item = new Resposta()
            {
                Id = resposta.Id,
                Data = (DateTime)resposta.Data,
                Descricao = (string)resposta.Descricao,
                Observacoes = (string)resposta.Observacoes,
                Prazo = (DateTime)resposta.Prazo,
                VerificaRetorno = (string)resposta.VerificaRetorno,
                // IdEvento= (int)resposta.IdEvento,
                IdPessoa = (int)resposta.IdPessoa,
                Eventos = JsonConvert.DeserializeObject<ICollection<RespostaEventos>>(resposta.JsonEventos)
            };

            ServicoResposta.Create(item);
        }

        public RespostaViewModel CarregarRegistro(int idResposta)
        {
            var registro = ServicoResposta.CarregarRegistro(idResposta);

            RespostaViewModel resposta = new RespostaViewModel()
            {
                Id = registro.Id,
                Data = (DateTime)registro.Data,
                Descricao = (string)registro.Descricao,
                Observacoes = (string)registro.Observacoes,
                Prazo = (DateTime)registro.Prazo,
                VerificaRetorno = (string)registro.VerificaRetorno,
                // IdEvento= (int)registro.IdEvento,
                IdPessoa = (int)registro.IdPessoa
              
            };

            return resposta;
        }

        public void Excluir(int id)
        {
            ServicoResposta.Excluir(id);
        }

        public IEnumerable<RespostaViewModel> Listagem()
        {
            var lista = ServicoResposta.Listagem();
            List<RespostaViewModel> listaResposta = new List<RespostaViewModel>();

            foreach (var item in lista)
            {
                RespostaViewModel resposta = new RespostaViewModel()
                {
                    Id = item.Id,
                    Data = (DateTime)item.Data,
                    Descricao = (string)item.Descricao,
                    Observacoes = (string)item.Observacoes,
                    Prazo = (DateTime)item.Prazo,
                    VerificaRetorno = (string)item.VerificaRetorno,
                    // IdEvento= (int)item.IdEvento,
                    //  DescricaoEvento = item.Evento.Descricao,
                    IdPessoa = (int)item.IdPessoa
                };

                listaResposta.Add(resposta);
            }

            return listaResposta;
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            List<GraficoViewModel> lista = new List<GraficoViewModel>();

            var auxLista = ServicoResposta.ListaGrafico();

            foreach (var item in auxLista)
            {
                GraficoViewModel grafico = new GraficoViewModel()
                {
                    IdEvento = item.IdEvento,
                    Descricao = item.Descricao,
                    TotalVendido = item.TotalVendido
                };
                lista.Add(grafico);
            }

            return lista;
        }
    }
}
