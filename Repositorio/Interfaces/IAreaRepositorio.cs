using System.Threading.Tasks;
using RelacionaW3.Dominio.Models;

namespace RelacionaW3.Repositorio.Interfaces
{
    public interface IAreaRepositorio : IRepositorioGenerico<Area>
    {
        // Task<IEnumerable<Area>> GetAllArea();
        Task<bool> AreaExiste(string Descricao);
        Task<bool> AreaExiste(string Descricao, int Id);
        Task DeleteArea(int id, string idUsuario);
       

       
    }
}
