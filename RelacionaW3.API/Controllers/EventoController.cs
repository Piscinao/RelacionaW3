using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.Dominio;
using RelacionaW3.Repositorio;
 
namespace RelacionaW3.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {   //injeção de dependencia
        private readonly IRelacionaW3Repositorio _repo;
        public EventoController(IRelacionaW3Repositorio repo)
        {
           _repo = repo;
        }
    
    [HttpGet]
        //requisição assincrona
        public async Task<IActionResult> Get()
        {

            try 
            {
                var results = await _repo.GetAllEventoAsync(true);
                
                return  Ok(results);

            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
            
           }

        [HttpGet("{EventoId}")]
        //requisição assincrona
        public async Task<IActionResult> Get(int EventoId)
        {

            try 
            {
                var results = await _repo.GetEventoAsyncById(EventoId, true);
                
                return  Ok(results);

            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
            
           }
     
        [HttpGet("getByTema/{tema}")]
        //requisição assincrona
        public async Task<IActionResult> Get(string tema)
        {

            try 
            {
                var results = await _repo.GetAllEventoAsyncByTema(tema, true);
                
                return  Ok(results);

            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }

           }

        [HttpPost]
        //requisição assincrona
        public async Task<IActionResult> Post(Evento model)
        {

            try 
            {
                _repo.Add(model);
                
                if(await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                     return Created($"/api/evento/{model.Id}", model);
                }
            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }   
                return BadRequest();

           }

        [HttpPut]
        //requisição assincrona
        public async Task<IActionResult> Put(int EventoId, Evento model)
        {

            try 
            {
                var evento = await _repo.GetEventoAsyncById(EventoId, false);
                if(evento == null) return NotFound();
                
                _repo.Update(model);
                
                if(await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                     return Created($"/api/evento/{model.Id}", model);
                }
              
            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
                return BadRequest();
           }

        [HttpDelete]
        //requisição assincrona
        public async Task<IActionResult> Delete(int EventoId)
        {

            try 
            {
                var evento = await _repo.GetEventoAsyncById(EventoId, false);
                if(evento == null) return NotFound();
                _repo.Delete(evento);
                
                if(await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                     return Ok();
                }
              
            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
                return BadRequest();
           }

        }
}