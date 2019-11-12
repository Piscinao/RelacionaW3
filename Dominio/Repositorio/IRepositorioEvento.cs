using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Repositorio
{
    public interface IRepositorioEvento : IRepositorio<Evento>
    {
        new IEnumerable<Evento> Read();
    }
}
