using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using RelacionaW3.Repositorio.Interfaces;
using System.Threading.Tasks;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Entidades
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly SignInManager<Usuario> _gerenciadorLogin;
        private readonly UserManager<Usuario> _gerenciadorUsuario;

        public UsuarioRepositorio(Context contexto, SignInManager<Usuario> gerenciadorLogin, UserManager<Usuario> gerenciadorUsuario) : base(contexto)
        {
            _gerenciadorLogin = gerenciadorLogin;
            _gerenciadorUsuario = gerenciadorUsuario;
        }

        public async Task<Usuario> PegarUsuarioLogado(ClaimsPrincipal usuario)
        {
            return await _gerenciadorUsuario.GetUserAsync(usuario);
        }

        public async Task<IdentityResult> SalvarUsuario(Usuario usuario, string senha)
        {
            return await _gerenciadorUsuario.CreateAsync(usuario, senha);
        }

        public async Task AtribuirNivelAcesso(Usuario usuario, string nivelAcesso)
        {
            await _gerenciadorUsuario.AddToRoleAsync(usuario, nivelAcesso);
        }

        public async Task EfetuarLogin(Usuario usuario, bool lembrar)
        {
            await _gerenciadorLogin.SignInAsync(usuario, lembrar);
        }

        public async Task EfetuarLogOut()
        {
            await _gerenciadorLogin.SignOutAsync();
        }
        
        public async Task<Usuario> PegarUsuarioPeloEmail(string email)
        {
            return await _gerenciadorUsuario.FindByEmailAsync(email);
        }

        public async Task AtualizarUsuario(Usuario usuario)
        {
            await _gerenciadorUsuario.UpdateAsync(usuario);
        }
    }
}
