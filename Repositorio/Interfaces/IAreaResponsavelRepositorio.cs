using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IAreaResponsavelRepositorio : IRepositorioGenerico<AreaResponsavel>
    {
        // Task<IEnumerable<Area>> GetAllArea();
        Task<bool> AreaExiste(string Descricao);
        Task<bool> AreaExiste(string Descricao, int Id);

        // Task DeleteArea(int id);

        //  Task<AreaResponsavel> GetAreaById(int IdArea, string IdUsuario);
        // Task<bool> EventoAreaByUsuario(int IdArea, string IdUsuario);
       
    }
}
