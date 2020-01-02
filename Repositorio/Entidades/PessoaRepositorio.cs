using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Entidades
{
    public class PessoaRepositorio : RepositorioGenerico<Pessoa>, IPessoaRepositorio
    {
        private readonly Context _contexto;
        public PessoaRepositorio(Context contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public async Task<bool> PessoaExiste(string Nome)
        {
            return await _contexto.Pessoa.AnyAsync(a => a.Nome == Nome);
        }

        public async Task<bool> PessoaExiste(string Nome, int Id)
        {
            return await _contexto.Pessoa.AnyAsync(a => a.Nome == Nome && a.Id != Id);
        }

         public async Task<Pessoa> PegarDadosPessoaPeloId(int Id)
         {
             return await _contexto.Pessoa.Include(a => a.Classificacao).Where(a => a.Id == Id).FirstAsync();
         }

    
         public async Task<IEnumerable<Pessoa>> GetAllPerson()
        {
            return await _contexto.Pessoa.Include(e => e.Nome).ToListAsync();
        }


        // public string PegarNomeAlunoPeloId(int id)
        // {
        //     return _contexto.Pessoas.Where(a => a.AlunoId == id).Select(a => a.Nome).First();
        // }

        // public new async Task<IEnumerable<Pessoa>> PegarTodos()
        // {
        //     return await _contexto.Pessoas.Include(a => a.Objetivo).Include(a => a.Professor).ToListAsync();
        // }
    }
}
