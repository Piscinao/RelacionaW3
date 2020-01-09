using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Newtonsoft.Json;
using RelacionaW3.MVC.Models;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class AreaController : Controller
    {
        private readonly IAreaRepositorio _areaRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public AreaController(IAreaRepositorio areaRepositorio, IUsuarioRepositorio usuarioRepositorio)
        {
            _areaRepositorio = areaRepositorio;
            _usuarioRepositorio = usuarioRepositorio;
           
        }

        // GET: Professores
        public async Task<IActionResult> Index()
        {
            return View(await _areaRepositorio.GetAll().ToListAsync());
        } 
        

        public IActionResult Create()
        {
            ViewData["IdUsuario"] = new SelectList(_usuarioRepositorio.GetAll(), "Id", "Nome");
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AreaViewModel area)
        {
            if (ModelState.IsValid)
            {
                Area item = new Area()
            {
                Id = area.Id,
                Descricao = (string)area.Descricao,
                
                //Json DeserializeObject Pega o conteúdo que vem em formato de string para uma classe
                Usuarios = JsonConvert.DeserializeObject<ICollection<AreaResponsavel>>(area.JsonUsuarios)
            };
                TempData["msgSuccess"] = "Registrar";
                await _areaRepositorio.Create(item);
                return RedirectToAction(nameof(Index));
            }
           
             ViewData["IdUsuario"] = new SelectList(_usuarioRepositorio.GetAll(), "Id", "Nome");

             TempData["msgError"] = "Erro";               
             return View(area);
        }
       
        public async Task<IActionResult> Edit(int id)
        {
            var area = await _areaRepositorio.GetById(id);
            if (area == null)
            {
                return NotFound();
            }

           

            return View(area);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Descricao")] Area area)
        {
            if (id != area.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _areaRepositorio.Update(area);

                 TempData["msgSuccess"] = "Registrar";

                return RedirectToAction(nameof(Index));
            }

            TempData["msgError"] = "Erro";  
            return View(area);
        }  
       
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _areaRepositorio.Delete(id);
            return Json("Area excluído com sucesso");
        }

        public async Task<JsonResult> AreaExiste(string Descricao, int Id)
        {
            if (Id == 0)
            {
                if(await _areaRepositorio.AreaExiste(Descricao))
                    return Json("Area já existe");

                return Json(true);
            }

            else
            {
                if (await _areaRepositorio.AreaExiste(Descricao, Id))
                    return Json("Area já existe");

                return Json(true);
            }
        }
    }
}
