using Aplicacao.Servico.Interfaces;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Entidades;
using RelacionaW3.MVC.Models;
using System.Collections.Generic;

namespace Aplicacao.Servico
{
    // Mapeamento intermediário do domínio via servico
    public class ServicoAplicacaoArea : IServicoAplicacaoArea
    {

        // Injeção de dependencia chama a iterface do dominio
        // Servico é do domínio, servicoaplicacao é o mapeamento
        private readonly IServicoArea ServicoArea;

        // parametro da injeção - coloca como parametro a injeção no construtor da classe
        public ServicoAplicacaoArea(IServicoArea servicoArea)
        {
            // atribuição o objeto servicoArea recebe - injetando a Interface na aplicação
            ServicoArea = servicoArea;
        }

        public void Create(AreaViewModel area)
        {
            Area item = new Area()
            {
                Id = area.Id,
                Descricao = area.Descricao
            };

            ServicoArea.Create(item);
        }

        public AreaViewModel CarregarRegistro(int idArea)
        {
            var registro = ServicoArea.CarregarRegistro(idArea);

            // Maepamento do objeto que recebeu para o objeto que queira utilzar
            AreaViewModel area = new AreaViewModel()
            {
                Id = registro.Id,
                Descricao = registro.Descricao
            };

            return area;
        }

        public void Excluir(int id)
        {
            ServicoArea.Excluir(id);
        }

        public IEnumerable<SelectListItem> ListaAreasDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();

            var lista = this.Listagem();

            foreach (var item in lista)
            {
                SelectListItem area = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Descricao
                };
                retorno.Add(area);
            }

            return retorno;
        }

        public IEnumerable<AreaViewModel> Listagem()
        {
            // variavel que busca a listagem da interface pelo dominio
            // Dominio que retorna o objeto
            var lista = ServicoArea.Listagem();

            // Retorna em uma lista via viewmodel
            List<AreaViewModel> listaArea = new List<AreaViewModel>();
            
            // loop 
            foreach (var item in lista)
            {
                AreaViewModel area = new AreaViewModel()
                {
                    Id = item.Id,
                    Descricao = item.Descricao
                };
                // Cada iteração adiciona 
                listaArea.Add(area);
            }

            return listaArea;
        }
    }
}
