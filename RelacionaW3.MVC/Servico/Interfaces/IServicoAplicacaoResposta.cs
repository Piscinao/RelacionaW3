using RelacionaW3.MVC.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoResposta
    {
        IEnumerable<GraficoViewModel> ListaGrafico();

        IEnumerable<RespostaViewModel> Listagem();

        RespostaViewModel CarregarRegistro(int idResposta);

        EventoViewModel CarregarStatus(int idEvento);

        void Create(RespostaViewModel resposta);

        void Excluir(int id);
    }
}
