using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class PessoaController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoaController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
           
        }

        // GET: Professores 
        public async Task<IActionResult> Index()
        {
            return View(await _pessoaRepositorio.GetAll().ToListAsync());
        } 
        
        // public IActionResult Create()
        // {
        //     return View();
        // }

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome, CPF, CNPJ, Email, Telefone, Celular, Classificacao, Empresa")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                TempData["msgSuccess"] = "Registrar";
                
                await _pessoaRepositorio.Create(pessoa);
                return RedirectToAction(nameof(Index));
            }

             TempData["msgError"] = "Erro";               
             return View(pessoa);
        }
       
        public async Task<IActionResult> Edit(int id)
        {
            var pessoa = await _pessoaRepositorio.GetById(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            

            return View(pessoa);
        }

         public async Task<IActionResult> Details(int id)
        {
           var pessoa = await _pessoaRepositorio.GetById(id);
            if (pessoa == null)
            {
                return NotFound();
            }

            return View(pessoa);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome, CPF, CNPJ, Email, Telefone, Celular, Classificacao, Empresa")] Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _pessoaRepositorio.Update(pessoa);

                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }  
       
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _pessoaRepositorio.Delete(id);
            return Json("Pessoa excluído com sucesso");
        }

        public async Task<JsonResult> PessoaExiste(string Nome, int Id)
        {
            if (Id == 0)
            {
                if(await _pessoaRepositorio.PessoaExiste(Nome))
                    return Json("Pessoa já existe");

                return Json(true);
            }

            else
            {
                if (await _pessoaRepositorio.PessoaExiste(Nome, Id))
                    return Json("Pessoa já existe");

                return Json(true);
            }
        }
    }
}
