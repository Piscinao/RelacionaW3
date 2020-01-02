using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IEventoRepositorio : IRepositorioGenerico<Evento>
    {
        // new Task<IEnumerable<Evento>> GetAll();

        Task<IEnumerable<Evento>> GetAllEvento();
        // Task<IEnumerable<Evento>> GetAllEventoByUserId(ClaimsPrincipal usuario);
        // Task<Evento> PegarUsuarioLogado(ClaimsPrincipal usuario);
        Task<Evento> EventoById(int id);
        Task<bool> EventoExiste(string Descricao);
        
        Task<bool> EventoExiste(string Descricao, int Id);
        // Task<IEnumerable<Evento>> GetAllEventoByUserId();
    }
}
