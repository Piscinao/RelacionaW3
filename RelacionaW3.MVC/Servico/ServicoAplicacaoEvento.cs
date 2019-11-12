﻿using Aplicacao.Servico.Interfaces;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Entidades;
using RelacionaW3.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacao.Servico
{
    public class ServicoAplicacaoEvento : IServicoAplicacaoEvento
    {
        private readonly IServicoEvento ServicoEvento;

        public ServicoAplicacaoEvento(IServicoEvento servicoEvento)
        {
            ServicoEvento = servicoEvento;
        }

        public IEnumerable<SelectListItem> ListaEventosDropDownList()
        {
            List<SelectListItem> retorno = new List<SelectListItem>();

            var lista = this.Listagem();

            foreach (var item in lista)
            {
                SelectListItem evento = new SelectListItem()
                {
                    Value = item.Id.ToString(),
                    Text = item.Descricao,
                    
                };
                retorno.Add(evento);
            }

            return retorno;
        }

        // Criar registros
        public void Create(EventoViewModel evento)
        {
            Evento item = new Evento()
            {
                Id = evento.Id,
                Descricao = evento.Descricao,
                DataEvento = (DateTime)evento.DataEvento,
                Fonte = (string)evento.Fonte,
                Meio = (string)evento.Meio,
                Classificacao = (string)evento.Classificacao,
                Caracteristica = (string)evento.Caracteristica,
                Produto = (string)evento.Produto,
                NotaFiscal = (string)evento.NotaFiscal,
                DescricaoMaterial = (string)evento.DescricaoMaterial,
                Evidencias = (string)evento.Evidencias,
                Quantidade = evento.Quantidade,
                // DataEncaminhamento = (DateTime)evento.DataEncaminhamento,
                // Prazo = (DateTime)evento.Prazo,
                // Valor = (decimal)evento.Valor,
                IdPessoa = (int)evento.IdPessoa,
                IdArea = (int)evento.IdArea
            };

            ServicoEvento.Create(item);
        }


    // Atualizar registros
        public EventoViewModel CarregarRegistro(int idEvento)
        {
            var registro = ServicoEvento.CarregarRegistro(idEvento);

            EventoViewModel evento = new EventoViewModel()
            {
                Id = registro.Id,
                Descricao = registro.Descricao,
                DataEvento = (DateTime)registro.DataEvento,
                Fonte = (string)registro.Fonte,
                Meio = (string)registro.Meio,
                Classificacao = (string)registro.Classificacao,
                Caracteristica = (string)registro.Caracteristica,
                Produto = (string)registro.Produto,
                Quantidade = registro.Quantidade,
                NotaFiscal = (string)registro.NotaFiscal,
                DescricaoMaterial = (string)registro.DescricaoMaterial,
                Evidencias = (string)registro.Evidencias,
                // DataEncaminhamento = (DateTime)registro.DataEncaminhamento,
                // Prazo = (DateTime)registro.Prazo,
                Valor = (decimal)registro.Valor,
                IdPessoa = (int)registro.IdPessoa,
                IdArea = (int)registro.IdArea
            };

            return evento;
        }

        public void Excluir(int id)
        {
            ServicoEvento.Excluir(id);
        }


    // Listar registros
        public IEnumerable<EventoViewModel> Listagem()
        {
            var lista = ServicoEvento.Listagem();
            List<EventoViewModel> listaEvento = new List<EventoViewModel>();

            foreach (var item in lista)
            {
                EventoViewModel evento = new EventoViewModel()
                {
                    Id = item.Id,
                    Descricao = item.Descricao,
                    DataEvento = (DateTime)item.DataEvento,
                    Fonte = (string)item.Fonte,
                    Meio = (string)item.Meio,
                    Classificacao = (string)item.Classificacao,
                    Caracteristica = (string)item.Caracteristica,
                    Produto = (string)item.Produto,
                    Quantidade = item.Quantidade,
                    NotaFiscal = (string)item.NotaFiscal,
                    DescricaoMaterial = (string)item.DescricaoMaterial,
                    Evidencias = (string)item.Evidencias,
                    Status = (string)item.Status,
                    // DataEncaminhamento = (DateTime)item.DataEncaminhamento,
                    // Prazo = (DateTime)item.Prazo,
                    Valor = (decimal)item.Valor,
                    IdPessoa = (int)item.IdPessoa,
                    NomePessoa = item.Pessoa.Nome,
                    IdArea = (int)item.IdArea,
                    DescricaoArea = item.Area.Descricao
                };
                listaEvento.Add(evento);
            }

            return listaEvento;
        }
    }
}