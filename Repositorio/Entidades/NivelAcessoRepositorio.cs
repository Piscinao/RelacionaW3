using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using System.Threading.Tasks;

namespace RelacionaW3.Repositorio.Entidades
{
    public class NivelAcessoRepositorio : RepositorioGenerico<NivelAcesso>, INivelAcessoRepositorio
    {
        private readonly RoleManager<NivelAcesso> _gerenciadorNiveisAcesso;
        private readonly Context _contexto;

       

        public NivelAcessoRepositorio(Context contexto, RoleManager<NivelAcesso> gerenciadorNiveisAcesso) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorNiveisAcesso = gerenciadorNiveisAcesso;

        }

       
        public async Task<bool> NivelAcessoExiste(string nivelAcesso)
        {
            return await _gerenciadorNiveisAcesso.RoleExistsAsync(nivelAcesso);
        }
        

        
    }
}
