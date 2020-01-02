using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace RelacionaW3.Repositorio.Entidades
{
    public class EventoRepositorio : RepositorioGenerico<Evento>, IEventoRepositorio
    {
        private readonly Context _contexto;


        public EventoRepositorio(Context contexto,  IUsuarioRepositorio usuarioRepositorio) : base(contexto)
        {
             _contexto = contexto;
          


        }

        // public async Task<Evento> PegarUsuarioLogado(ClaimsPrincipal usuario)
        // {
        //     return await _gerenciadorUsuario.GetUserAsync(usuario);
        // }

        //    public async Task<IEnumerable<Usuario>> GetAllEventoByUserId(Usuario usuario2)
        // {
        //     // var usuario = await _usuarioRepositorio.PegarUsuarioLogado(usuario2);
        //     return await _contexto.Evento.Include(e => e.Usuario).Where(e => e.IdUsuario == usuario.Id).ToListAsync();
        // }

        public async Task<bool> EventoExiste(string Descricao)
        {
            return await _contexto.Evento.AnyAsync(a => a.Descricao == Descricao);
        }

        public async Task<bool> EventoExiste(string Descricao, int Id)
        {
            return await _contexto.Evento.AnyAsync(a => a.Descricao == Descricao && a.Id != Id);
        }

         public async Task<Evento> EventoById(int id)
        {
            return await _contexto.Evento.Include(a => a.Area).Include(a => a.Pessoa).Where(a => a.Id == id).FirstAsync();
        }


           public async Task<IEnumerable<Evento>> GetAllEvento()
        {
            return await _contexto.Evento.Include(e => e.Area).Include(e=> e.Pessoa).ToListAsync();
        }

        

        //  public async Task<IEnumerable<Evento>> GetAllEvento()
        // {
        //     return await _contexto.Evento.Include(e => e.Descricao).ToListAsync();
        // }


        // public string PegarDescricaoAlunoPeloId(int id)
        // {
        //     return _contexto.Pessoas.Where(a => a.AlunoId == id).Select(a => a.Nome).First();
        // }

        // public new async Task<IEnumerable<Pessoa>> PegarTodos()
        // {
        //     return await _contexto.Pessoas.Include(a => a.Objetivo).Include(a => a.Professor).ToListAsync();
        // }
    }
}
