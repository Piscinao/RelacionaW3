
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class RespostaController : Controller
    {
        private readonly IRespostaRepositorio _respostaRepositorio;
        private readonly IEventoRepositorio _eventoRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public RespostaController(
        IRespostaRepositorio respostaRespositorio, 
        IEventoRepositorio eventoRepositorio,
        IPessoaRepositorio pessoaRepositorio)
        {
            _respostaRepositorio = respostaRespositorio;
           _eventoRepositorio = eventoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
           
        }

        public async Task<IActionResult> Index()
        {
            return View(await _respostaRepositorio.GetAll());
        }   
        
     
         public IActionResult Create()
        {
            ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
            ViewData["IdEvento"] = new SelectList(_eventoRepositorio.GetAll(), "Id", "Descricao");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RespostaViewModel resposta)
        {
            if (ModelState.IsValid)
            {
                Resposta item = new Resposta()
            {
                Id = resposta.Id,
                Data = (string)resposta.Data,
                Descricao = (string)resposta.Descricao,
                Observacoes = (string)resposta.Observacoes,
                Prazo = (string)resposta.Prazo,
                VerificaRetorno = (string)resposta.VerificaRetorno,
                // IdEvento= (int)resposta.IdEvento,
                IdPessoa = (int)resposta.IdPessoa,
                //Json DeserializeObject Pega o conteúdo que vem em formato de string para uma classe
                Eventos = JsonConvert.DeserializeObject<ICollection<RespostaEventos>>(resposta.JsonEventos)
            };
                TempData["msgSuccess"] = "Registrar";
                await _respostaRepositorio.Create(item);
                return RedirectToAction(nameof(Index));
   
            }
           
            ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
            ViewData["IdEvento"] = new SelectList(_eventoRepositorio.GetAll(), "Id", "Descricao");

             TempData["msgError"] = "Erro";               
             return View(resposta);
        }
       
        public async Task<IActionResult> Edit(int id)
        {
            var evento = await _respostaRepositorio.GetById(id);
            if (evento == null)
            {
                return NotFound();
            }

           

            return View(evento);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descricao")] Resposta evento)
        {
            if (id != evento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _respostaRepositorio.Update(evento);

                 TempData["msgSuccess"] = "Registrar";

                return RedirectToAction(nameof(Index));
            }

            TempData["msgError"] = "Erro";  
            return View(evento);
        }  
       
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _respostaRepositorio.Delete(id);
            return Json("Resposta excluído com sucesso");
        }

        public async Task<JsonResult> RespostaExiste(string Descricao, int Id)
        {
            if (Id == 0)
            {
                if(await _respostaRepositorio.RespostaExiste(Descricao))
                    return Json("Resposta já existe");

                return Json(true);
            }

            else
            {
                if (await _respostaRepositorio.RespostaExiste(Descricao, Id))
                    return Json("Resposta já existe");

                return Json(true);
            }
        }
    }
}









// using Aplicacao.Servico.Interfaces;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using RelacionaW3.MVC.Models;
// using RelacionaW3.Repositorio.Interfaces;

// namespace RelacionaW3.Controllers
// {
//     [Authorize]
//     public class RespostaController : Controller
//     {
//         readonly IEventoRepositorio _eventoRepositorio;
//         readonly IPessoaRepositorio _pessoaRepositorio;
//         readonly IRespostaRepositorio _respostaRepositorio;

//         public RespostaController(
//             IEventoRepositorio eventoRepositorio,
//             IPessoaRepositorio pessoaRepositorio,
//             IRespostaRepositorio respostaRepositorio)
//         {
//             _eventoRepositorio = eventoRepositorio;
//             _pessoaRepositorio = pessoaRepositorio;
//             _respostaRepositorio = respostaRepositorio;
//         }

//         public IActionResult Index()
//         {           
//             return View(_respostaRepositorio.GetAll());
//         }

//         [HttpGet]
//         public IActionResult Create(int? id)
//         {
//             RespostaViewModel viewModel = new RespostaViewModel();

//             if (id!=null)
//             {
//                 viewModel = _respostaRepositorio.GetById((int)id);
             
//             }   

//             viewModel.ListaPessoas = _pessoaRepositorio.ListaPessoasDropDownList();
//             viewModel.ListaEventos = _eventoRepositorio.ListaEventosDropDownList();

//             return View(viewModel);
//         }

//         [HttpPost]
//         public IActionResult Create(RespostaViewModel entidade)
//         {
//             EventoViewModel viewModel = new EventoViewModel();
//             if (ModelState.IsValid)
//             {
//                 _respostaRepositorio.Create(entidade);
//                 TempData["msgSuccess"] = "Registrar";
//             }
//             else
//             {
//                 TempData["msgError"] = "Erro";
//                 entidade.ListaPessoas = _pessoaRepositorio.ListaPessoasDropDownList();
//                 entidade.ListaEventos = _eventoRepositorio.ListaEventosDropDownList();
//                 return View(entidade);
//             }

//             return RedirectToAction("Index");
//         }

//         [HttpGet]
//         public IActionResult Excluir(int id)
//         {
//             _respostaRepositorio.Excluir(id);
//             TempData["msgDelete"] = "Excluir";
//             return RedirectToAction("Index");
//         }

//         [HttpGet("LerValorEvento/{IdEvento}")]
//         public decimal LerValorEvento(int IdEvento)
//         {
//             //Retorna um valor do model evento via servico
//             return (decimal)_eventoRepositorio.CarregarRegistro(IdEvento).Valor;
//         }
//     }
// }