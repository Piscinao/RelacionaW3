using Dominio.Interfaces;
using Dominio.Repositorio;
using RelacionaW3.Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Servicos
{
    public class ServicoPessoa : IServicoPessoa
    {
        IRepositorioPessoa RepositorioPessoa;

        public ServicoPessoa(IRepositorioPessoa repositorioPessoa)
        {
            RepositorioPessoa = repositorioPessoa;
        }

        public void Create(Pessoa pessoa)
        {
            RepositorioPessoa.Create(pessoa);
            
        }

        public Pessoa CarregarRegistro(int id)
        {
            return RepositorioPessoa.Read(id);
        }

        public void Excluir(int id)
        {
            RepositorioPessoa.Delete(id);
        }

        public IEnumerable<Pessoa> Listagem()
        {
            return RepositorioPessoa.Read();          
        }
    }
}
