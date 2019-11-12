using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
