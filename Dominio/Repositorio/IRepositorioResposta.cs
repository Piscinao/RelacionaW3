using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Repositorio
{
    public interface IRepositorioResposta : IRepositorio<Resposta>
    {
        new void Delete(int id);

    
    }
}
