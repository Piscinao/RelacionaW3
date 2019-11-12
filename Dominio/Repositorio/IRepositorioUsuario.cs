using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Repositorio
{
    public interface IRepositorioUsuario : IRepositorio<Usuario>
    {
        bool ValidarLogin(string email, string senha);
    }
}
