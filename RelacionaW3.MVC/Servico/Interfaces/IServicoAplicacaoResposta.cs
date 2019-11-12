using RelacionaW3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoResposta
    {
        IEnumerable<GraficoViewModel> ListaGrafico();

        IEnumerable<RespostaViewModel> Listagem();

        

        RespostaViewModel CarregarRegistro(int idResposta);

        void Create(RespostaViewModel resposta);

        void Excluir(int id);
    }
}
