using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IPessoaRepositorio : IRepositorioGenerico<Pessoa>
    {
        Task<IEnumerable<Pessoa>> GetAllPerson();
        Task<bool> PessoaExiste(string Nome);
        Task<bool> PessoaExiste(string Nome, int Id);

        // IEnumerable<SelectListItem> ListaPessoasDropDownList();

        // IEnumerable<Pessoa> Listagem();
       
    }
}
