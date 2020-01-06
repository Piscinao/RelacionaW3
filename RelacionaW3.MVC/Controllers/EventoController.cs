using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RelacionaW3.Dominio.Models;
using RelacionaW3.Repositorio.Interfaces;
using RelacionaW3.Repositorio.Servicos;

namespace RelacionaW3.Controllers
{
    [Authorize]
    public class EventoController : Controller
    {
        private readonly IEventoRepositorio _eventoRepositorio;
        private readonly IAreaRepositorio _areaRepositorio;
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IEmail _email;

        public EventoController(
        IEventoRepositorio eventoRepositorio, 
        IAreaRepositorio areaRepositorio,
        IPessoaRepositorio pessoaRepositorio,
        IUsuarioRepositorio usuarioRepositorio,
        IEmail email)
        {
           _eventoRepositorio = eventoRepositorio;
           _areaRepositorio = areaRepositorio;
           _pessoaRepositorio = pessoaRepositorio;
           _email = email;
           _usuarioRepositorio = usuarioRepositorio;
           
        }

        public async Task<IActionResult> IndexAdm()
        {
            return View(await _eventoRepositorio.GetAllEvento());
        }   

        // public async Task<IActionResult> Index2()

        // {
        //     return View(await _eventoRepositorio.GetAllEvento());
        //     //  return View(await _eventoRepositorio.PegarUsuarioLogado(User));
        // }   

        public async Task<IActionResult> Index()

        {
             
             return View(await _usuarioRepositorio.PegarUsuarioLogado(User));
        }   

        public async Task<IActionResult> IndexArea()
    
        {   
             return View(await _usuarioRepositorio.PegarUsuarioLogado(User));
        }   

        
     
         public IActionResult Create()
        {
            ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
            ViewData["IdArea"] = new SelectList(_areaRepositorio.GetAll(), "Id", "Descricao");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Evento evento)
        {
            if (ModelState.IsValid)
            {
                var usuario = await _usuarioRepositorio.PegarUsuarioLogado(User);
                Evento item = new Evento()
            {
                Id = evento.Id,
                Descricao = (string)evento.Descricao,
                DataEvento = (string)evento.DataEvento,
                Quantidade = (string)evento.Quantidade,
                Meio = (string)evento.Meio,
                Fonte = (string)evento.Fonte,
                NotaFiscal = (string)evento.NotaFiscal,
                DescricaoMaterial = (string)evento.DescricaoMaterial,
                Evidencias = (string)evento.Evidencias,
                Caracteristica = (string)evento.Caracteristica,
                Status = "1",
                IdPessoa = (int)evento.IdPessoa,
                // NomePessoa= (string)evento.Pessoa.Nome,
                IdArea = (int)evento.IdArea,    
                IdUsuario = (string)usuario.Id
                // DescricaoArea = (string)evento.Area.Descricao,
             
            };
                string assunto = "Evento registrado com sucesso!";

                string mensagem = string.Format("Seu relato foi registrado com sucesso. Caso necessário você terá um retorno em breve do relato: {0}" +
                        " Meio de contato: {1}. Data de registro:{2}.", evento.Descricao, evento.Meio, evento.DataEvento);

                await _email.EnviarEmail(usuario.Email, assunto, mensagem);

                TempData["msgSuccess"] = "Registrar";
                await _eventoRepositorio.Create(item);
                return RedirectToAction(nameof(Index));
     
            }
           
            ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
            ViewData["IdArea"] = new SelectList(_areaRepositorio.GetAll(), "Id", "Descricao");

             TempData["msgError"] = "Erro";               
             return View(evento);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var evento = await _eventoRepositorio.GetById(id);
            if (evento == null)
            {
                
                return NotFound();
            }

            ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
            ViewData["IdArea"] = new SelectList(_areaRepositorio.GetAll(), "Id", "Descricao");

            return View(evento);
        }

        //  public async Task<IActionResult> Details(int id)
        // {
        //    var evento = await _eventoRepositorio.GetById(id);
        //     if (evento == null)
        //     {
        //         return NotFound();
        //     }

        //      ViewData["IdArea"] =  new SelectList(_areaRepositorio.GetAll(), "Id", "Descricao");

        //     return View(evento);
        // }

        public async Task<IActionResult> Details(int id)
           {
           var evento = await _eventoRepositorio.EventoById(id);


            if (evento == null)
            {
                return NotFound();
            }

            return View(evento);
        }

        //  public async Task<IActionResult> Details(int id)
        //    {
        //    var detalhe = await _eventoRepositorio.GetDetails(id);
      
        //     DetalhesViewModel evento = new  DetalhesViewModel()
        //     {
        //         // Id = detalhe.Id,
        //         // Descricao = (string)detalhe.Descricao,
        //         // DataEvento = (string)detalhe.DataEvento,
        //         // Quantidade = (string)detalhe.Quantidade,
        //         // Meio = (string)detalhe.Meio,
        //         // Fonte = (string)detalhe.Fonte,
        //         // NotaFiscal = (string)detalhe.NotaFiscal,
        //         // DescricaoMaterial = (string)detalhe.DescricaoMaterial,
        //         // Evidencias = (string)detalhe.Evidencias,
        //         // Caracteristica = (string)detalhe.Caracteristica,
        //         IdPessoa = (int)detalhe.IdPessoa,
        //         NomePessoa = (string)detalhe.Area.Descricao,
        //         // NomePessoa= (string)evento.Pessoa.Nome,
        //         IdArea = (int)detalhe.IdArea,    
        //         DescricaoArea = (string)detalhe.Area.Descricao,
        //     };

           

        //     return View(evento);
        // }

        //   public async Task<IActionResult> Details(int IdArea, int IdPessoa, int id)

        // {
        //     var evento = await _eventoRepositorio.GetById(id);
        //     if (evento == null)
        //     {
                
        //         return NotFound();
        //     }

        //     ViewData["IdArea"] = IdArea;
        //     ViewData["IdPessoa"] = IdPessoa;

        //      return View(evento);
        // }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Descricao, DataEvento, Quantidade, Meio, Email, Telefone, IdPessoa, Fonte, NotaFiscal, DescricaoMaterial, Evidencias, Caracteristica, Valor, Status, IdArea")] Evento evento)
        {
            if (id != evento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                await _eventoRepositorio.Update(evento);

                return RedirectToAction(nameof(Index));
            }

            ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
            ViewData["IdArea"] = new SelectList(_areaRepositorio.GetAll(), "Id", "Descricao");
            return View(evento);
        }  

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, Evento evento)
        // {

        //     var evento2 = await _eventoRepositorio.GetById(id);
        //      if (id != evento.Id)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //            Evento item = new Evento()
        //     {
        //         Id = (int)evento.Id,
        //         Descricao = (string)evento.Descricao,
        //         DataEvento = (string)evento.DataEvento,
        //         Meio = (string)evento.Meio,
        //         Fonte = (string)evento.Fonte,
        //         NotaFiscal = (string)evento.NotaFiscal,
        //         DescricaoMaterial = (string)evento.DescricaoMaterial,
        //         Evidencias = (string)evento.Evidencias,
        //         Caracteristica = (string)evento.Caracteristica,
        //         Produto = (string)evento.Produto,
        //         IdArea = (int)evento.IdArea,
        //         IdPessoa = (int)evento.IdPessoa,
        //         Classificacao= (string)evento.Classificacao
                
        //     };
        //         TempData["msgSuccess"] = "Registrar";
        //         await _eventoRepositorio.Update(evento);

        //         return RedirectToAction(nameof(Index));
        //     }
       
        //     ViewData["IdPessoa"] = new SelectList(_pessoaRepositorio.GetAll(), "Id", "Nome");
        //     ViewData["IdArea"] = new SelectList(_areaRepositorio.GetAll(), "Id", "Descricao");

        //     TempData["msgError"] = "Erro";  
        //     return View(evento);
        // }  
   
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _eventoRepositorio.Delete(id);
            return Json("Evento excluído com sucesso");
        }

        public async Task<JsonResult> EventoExiste(string Descricao, int Id)
        {
            if (Id == 0)
            {
                if(await _eventoRepositorio.EventoExiste(Descricao))
                    return Json("Evento já existe");

                return Json(true);
            }

            else
            {
                if (await _eventoRepositorio.EventoExiste(Descricao, Id))
                    return Json("Evento já existe");

                return Json(true);
            }
        }
    }
}
