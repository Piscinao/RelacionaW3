using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    public class RespostaController : Controller
    {
        readonly IServicoAplicacaoResposta ServicoAplicacaoResposta;
        readonly IServicoAplicacaoEvento ServicoAplicacaoEvento;
        readonly IServicoAplicacaoPessoa ServicoAplicacaoPessoa;

        public RespostaController(
            IServicoAplicacaoResposta servicoAplicacaoResposta,
            IServicoAplicacaoEvento servicoAplicacaoEvento,
            IServicoAplicacaoPessoa servicoAplicacaoPessoa)
        {
            ServicoAplicacaoResposta = servicoAplicacaoResposta;
            ServicoAplicacaoEvento = servicoAplicacaoEvento;
            ServicoAplicacaoPessoa = servicoAplicacaoPessoa;
        }

        public IActionResult Index()
        {           
            return View(ServicoAplicacaoResposta.Listagem());
        }

        [HttpGet]
        public IActionResult Create(int? id)
        {
            RespostaViewModel viewModel = new RespostaViewModel();

            if (id!=null)
            {
                viewModel = ServicoAplicacaoResposta.CarregarRegistro((int)id);
            }

            viewModel.ListaPessoas = ServicoAplicacaoPessoa.ListaPessoasDropDownList();
            viewModel.ListaEventos = ServicoAplicacaoEvento.ListaEventosDropDownList();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(RespostaViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoResposta.Create(entidade);
            }
            else
            {
                entidade.ListaPessoas = ServicoAplicacaoPessoa.ListaPessoasDropDownList();
                entidade.ListaEventos = ServicoAplicacaoEvento.ListaEventosDropDownList();
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ServicoAplicacaoResposta.Excluir(id);
            return RedirectToAction("Index");
        }

        [HttpGet("LerValorEvento/{IdEvento}")]
        public decimal LerValorEvento(int IdEvento)
        {
            return (decimal)ServicoAplicacaoEvento.CarregarRegistro(IdEvento).Valor;
        }
    }
}