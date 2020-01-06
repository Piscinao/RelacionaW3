using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Entidades
{
    public class AreaResponsavelRepositorio : RepositorioGenerico<AreaResponsavel>, IAreaResponsavelRepositorio
    {
        private readonly Context _contexto;
        private readonly IEventoRepositorio _eventoRepositorio;

       

        public AreaResponsavelRepositorio(Context contexto, IEventoRepositorio eventoRepositorio) : base(contexto)
        {
            _contexto = contexto;
            _eventoRepositorio = eventoRepositorio;

        }

        public async Task<bool> AreaExiste(string Descricao)
        {
            return await _contexto.Area.AnyAsync(a => a.Descricao == Descricao);
        }

        public async Task<bool> AreaExiste(string Descricao, int Id)
        {
            return await _contexto.Area.AnyAsync(a => a.Descricao == Descricao && a.Id != Id);
        }

        public async Task<bool> EventoAreaByUsuario(int IdArea, string IdUsuario)
        {
            return await _contexto.AreaResponsavel.AnyAsync(a => a.IdArea == IdArea && a.IdUsuario == IdUsuario);
        }

        // public async Task<bool> AreaExiste(int IdArea)
        // { 
        //     var eventoArea = await _eventoRepositorio.EventoById(IdArea);
        //     return await _contexto.AreaResponsavel.AnyAsync(a => a.IdArea == IdArea && a.IdUsuario == Id);
        // }

        

        
    }
}
