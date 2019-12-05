using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.MVC.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoArea
    {
        IEnumerable<SelectListItem> ListaAreasDropDownList();

        IEnumerable<AreaViewModel> Listagem();

        AreaViewModel CarregarRegistro(int idArea);

        void Create(AreaViewModel area);

        void Excluir(int id);
    }
}
