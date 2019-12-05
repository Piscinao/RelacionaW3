using Dominio.Interfaces;
using Dominio.Repositorio;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Servicos
{
    public class ServicoEvento : IServicoEvento
    {
        IRepositorioEvento RepositorioEvento;

        public ServicoEvento(IRepositorioEvento repositorioEvento)
        {
            RepositorioEvento = repositorioEvento;
        }

        public void Create(Evento evento)
        {
            RepositorioEvento.Create(evento);
        }

        public Evento CarregarRegistro(int id)
        {
            return RepositorioEvento.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioEvento.Delete(id);
        }
        
        public IEnumerable<Evento> Listagem()
        {
            return RepositorioEvento.Read();          
        }
    }
}
