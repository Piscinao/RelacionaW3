using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class AreaController : Controller
    {
        // Injeção de dependencia da interface
        readonly IServicoAplicacaoArea ServicoAplicacaoArea;

        // Injeção do serviço no construtor via parâmetro
        public AreaController(IServicoAplicacaoArea servicoAplicacaoArea)
        {
            // objeto                 Variavel
            ServicoAplicacaoArea = servicoAplicacaoArea;
        }

        public IActionResult Index()
        {           
            return View(ServicoAplicacaoArea.Listagem());
        }

        [HttpGet]
        public IActionResult Create(int? id)
        {
            AreaViewModel viewModel = new AreaViewModel();

            if (id != null)
            {
                viewModel = ServicoAplicacaoArea.CarregarRegistro((int)id);
            }
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(AreaViewModel entidade)
        {
            if (ModelState.IsValid)
            {
                ServicoAplicacaoArea.Create(entidade);
            }
            else
            {
                return View(entidade);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ServicoAplicacaoArea.Excluir(id);
            return RedirectToAction("Index");
        }
    }
}