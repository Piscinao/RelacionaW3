using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Entidades
{
    public class AreaRepositorio : RepositorioGenerico<Area>, IAreaRepositorio
    {
        private readonly Context _contexto;

       

        public AreaRepositorio(Context contexto) : base(contexto)
        {
            _contexto = contexto;

        }

        public async Task<bool> AreaExiste(string Descricao)
        {
            return await _contexto.Area.AnyAsync(a => a.Descricao == Descricao);
        }

        public async Task<bool> AreaExiste(string Descricao, int Id)
        {
            return await _contexto.Area.AnyAsync(a => a.Descricao == Descricao && a.Id != Id);
        }

        

        
    }
}
