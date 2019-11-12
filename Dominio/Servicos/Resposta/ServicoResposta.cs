using Dominio.Interfaces;
using Dominio.Repositorio;
using RelacionaW3.Dominio.DTO;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Servicos
{
    public class ServicoResposta : IServicoResposta
    {
        IRepositorioResposta RepositorioResposta;
        IRepositorioRespostaEventos RepositorioRespostaEventos;

        public ServicoResposta(
            IRepositorioResposta repositorioResposta,
            IRepositorioRespostaEventos repositorioRespostaEventos)
        {
            RepositorioResposta = repositorioResposta;
            RepositorioRespostaEventos = repositorioRespostaEventos;
        }

        public void Create(Resposta resposta)
        {
            RepositorioResposta.Create(resposta);
        }

        public Resposta CarregarRegistro(int id)
        {
            return RepositorioResposta.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioResposta.Delete(id);
        }

        public IEnumerable<Resposta> Listagem()
        {
            return RepositorioResposta.Read();          
        }

        public IEnumerable<GraficoViewModel> ListaGrafico()
        {
            return RepositorioRespostaEventos.ListaGrafico();
        }
    }
}
