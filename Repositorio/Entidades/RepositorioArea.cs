using RelacionaW3.Dominio.Entidades;
using Dominio.Repositorio;
using Repositorio.Contexto;

namespace Repositorio.Entidades
{
    // Classe concreta que implementa a interface de cada entidade do seu domínio
    // Repositorio<Area> Herda características da classe abstrata repositorio
    // IRepositorioArea Passa a entidade Area e por fim implementa a interface

    public class RepositorioArea : Repositorio<Area>, IRepositorioArea
    {
        public RepositorioArea(ApplicationDbContext dbContext) : base(dbContext) {
        }   
    }
}
