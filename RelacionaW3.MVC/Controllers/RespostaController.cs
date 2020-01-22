
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

        public async Task<IActionResult> Details(int id)

        {
           var resposta = await _respostaRepositorio.RespostaById(id);


            if (resposta == null)
            {
                return NotFound();
            }

            return View(resposta);
        }
       
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _respostaRepositorio.Delete(id);
            return Json("Resposta excluído com sucesso");
        }
          
        [HttpPost]
        public async Task<JsonResult> DeleteResposta(int id)
        {
            await _respostaRepositorio.DeleteResposta(id);
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
