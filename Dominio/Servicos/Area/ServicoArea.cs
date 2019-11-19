using Dominio.Interfaces;
using Dominio.Repositorio;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Servicos
{
    public class ServicoArea : IServicoArea
    {
        // Injeção para que o domínio acesse o repositório e faça a persistência
        IRepositorioArea RepositorioArea;

        // Referência é feita através da pasta Repositorio que contém as interfaces
        public ServicoArea(IRepositorioArea repositorioArea)
        {
            RepositorioArea = repositorioArea;
        }

        // Representa o insert da area Passa a entidade como parametro
        public void Create(Area area)
        {
            RepositorioArea.Create(area);
        }

        public Area CarregarRegistro(int id)
        {
            return RepositorioArea.Read(id);
        }

        // Espera um int id para exclusão
        public void Excluir(int id)
        {
            RepositorioArea.Delete(id);
        }

        // Espera a listagem das áreas
        public IEnumerable<Area> Listagem()
        {
            return RepositorioArea.Read();          
        }
    }
}
