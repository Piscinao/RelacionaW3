using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.DTO;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IEventoRepositorio : IRepositorioGenerico<Evento>
{

        Task<IEnumerable<Evento>> GetAllEvento();

        Task<Evento> EventoById(int id);
        Task<bool> EventoExiste(string Descricao);


         IEnumerable<GraficoViewModel> ListaGrafico(int IdArea, int IdEvento);
        
        Task<bool> EventoExiste(string Descricao, int Id);
       
    }
}
