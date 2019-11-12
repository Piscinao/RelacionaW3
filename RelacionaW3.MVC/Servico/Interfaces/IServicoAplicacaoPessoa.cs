using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico.Interfaces
{
    public interface IServicoAplicacaoPessoa
    {
        IEnumerable<SelectListItem> ListaPessoasDropDownList();

        IEnumerable<PessoaViewModel> Listagem();

        PessoaViewModel CarregarRegistro(int IdPessoa);

        void Create(PessoaViewModel pessoa);

        void Excluir(int id);
    }
}
