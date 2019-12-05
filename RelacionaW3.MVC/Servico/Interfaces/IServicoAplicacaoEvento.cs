using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.MVC.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoEvento
    {
        IEnumerable<SelectListItem> ListaEventosDropDownList();

        IEnumerable<EventoViewModel> Listagem();

        EventoViewModel CarregarRegistro(int idEvento);

        void Create(EventoViewModel evento);

        void Excluir(int id);
    }
}
