using Aplicacao.Servico.Interfaces;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Entidades;
using RelacionaW3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    
    public class ServicoAplicacaoPessoa : IServicoAplicacaoPessoa
    {
        private readonly IServicoPessoa ServicoPessoa;

        public ServicoAplicacaoPessoa(IServicoPessoa servicoPessoa)
        {
            ServicoPessoa = servicoPessoa;
        }

        public IEnumerable<SelectListItem> ListaPessoasDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();

            var lista = this.Listagem();

            foreach (var item in lista)
            {
                SelectListItem pessoa = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Nome
                };
                retorno.Add(pessoa);
            }

            return retorno;
        }

        public void Create(PessoaViewModel pessoa)
        {
            Pessoa item = new Pessoa()
            {
                Id = pessoa.Id,
                Nome = pessoa.Nome,
                Classificacao = pessoa.Classificacao,
                Empresa = pessoa.Empresa,
                CNPJ = pessoa.CNPJ,
                CPF = pessoa.CPF,
                Celular = pessoa.Celular,
                Telefone = pessoa.Telefone,
                Email = pessoa.Email
            };

            ServicoPessoa.Create(item);
        }

        public PessoaViewModel CarregarRegistro(int IdPessoa)
        {
            var registro = ServicoPessoa.CarregarRegistro(IdPessoa);

            PessoaViewModel pessoa = new PessoaViewModel()
            {
                Id = registro.Id,
                Nome = registro.Nome,
                Classificacao = registro.Classificacao,
                Empresa = registro.Empresa,
                CNPJ = registro.CNPJ,
                CPF = registro.CPF,
                Celular = registro.Celular,
                Telefone = registro.Telefone,
                Email = registro.Email
            };

            return pessoa;
        }

        public void Excluir(int id)
        {
            ServicoPessoa.Excluir(id);
        }

        public IEnumerable<PessoaViewModel> Listagem()
        {
            var lista = ServicoPessoa.Listagem();
            List<PessoaViewModel> listaPessoa = new List<PessoaViewModel>();

            foreach (var item in lista)
            {
                PessoaViewModel area = new PessoaViewModel()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Classificacao = item.Classificacao,
                    Empresa = item.Empresa,
                    CNPJ = item.CNPJ,
                    CPF = item.CPF,
                    Celular = item.Celular,
                    Telefone = item.Telefone,
                    Email = item.Email
                };
                listaPessoa.Add(area);
            }

            return listaPessoa;
        }
    }
}
