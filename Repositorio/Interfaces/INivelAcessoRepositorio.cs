using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface INivelAcessoRepositorio : IRepositorioGenerico<NivelAcesso>
    {
       Task<bool> NivelAcessoExiste(string nivelAcesso);
    }
}
