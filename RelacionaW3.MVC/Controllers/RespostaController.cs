using Aplicacao.Servico.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    [Authorize]
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
            EventoViewModel viewModel = new EventoViewModel();
            if (ModelState.IsValid)
            {
                ServicoAplicacaoResposta.Create(entidade);
                TempData["msgSuccess"] = "Registrar";
            }
            else
            {
                TempData["msgError"] = "Erro";
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
            TempData["msgDelete"] = "Excluir";
            return RedirectToAction("Index");
        }

        [HttpGet("LerValorEvento/{IdEvento}")]
        public decimal LerValorEvento(int IdEvento)
        {
            //Retorna um valor do model evento via servico
            return (decimal)ServicoAplicacaoEvento.CarregarRegistro(IdEvento).Valor;
        }
    }
}