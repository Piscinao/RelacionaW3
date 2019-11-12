using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers {
    public class EventoController : Controller {
        readonly IServicoAplicacaoEvento ServicoAplicacao;
        readonly IServicoAplicacaoArea ServicoAplicacaoArea;
        readonly IServicoAplicacaoPessoa ServicoAplicacaoPessoa;

        public EventoController (
            IServicoAplicacaoEvento servicoAplicacao,
            IServicoAplicacaoArea servicoAplicacaoArea,
            IServicoAplicacaoPessoa servicoAplicacaoPessoa) {
            ServicoAplicacao = servicoAplicacao;
            ServicoAplicacaoArea = servicoAplicacaoArea;
            ServicoAplicacaoPessoa = servicoAplicacaoPessoa;
        }

        public IActionResult Index () {
            return View (ServicoAplicacao.Listagem ());
        }

        [HttpGet]
        public IActionResult Create (int? id) {
            EventoViewModel viewModel = new EventoViewModel ();

            if (id != null) {
                viewModel = ServicoAplicacao.CarregarRegistro ((int) id);
            }
  
            viewModel.ListaPessoas = ServicoAplicacaoPessoa.ListaPessoasDropDownList ();
            viewModel.ListaAreas = ServicoAplicacaoArea.ListaAreasDropDownList ();

            return View (viewModel);
        }

        [HttpPost]
        public IActionResult Create (EventoViewModel entidade) {
            if (ModelState.IsValid) {
                ServicoAplicacao.Create (entidade);
            } else {
                entidade.ListaPessoas = ServicoAplicacaoPessoa.ListaPessoasDropDownList ();
                entidade.ListaAreas = ServicoAplicacaoArea.ListaAreasDropDownList ();
                return View (entidade);
            }

            return RedirectToAction ("Index");
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            ServicoAplicacao.Excluir (id);
            return RedirectToAction ("Index");
        }
    }
}