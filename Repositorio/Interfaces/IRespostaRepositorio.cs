using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IRespostaRepositorio : IRepositorioGenerico<Resposta>
    {
        new Task<IEnumerable<Resposta>> GetAll();
        Task<bool> RespostaExiste(string Descricao);
        Task<bool> RespostaExiste(string Descricao, int Id);
        
        Task DeleteResposta(int id);
        Task<Resposta> RespostaById(int id);
    }
}
