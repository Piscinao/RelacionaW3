using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.API.Dtos;
using RelacionaW3.Dominio;
using RelacionaW3.Repositorio;

namespace RelacionaW3.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    //aspnet.core não precisa isvalid entende que envia via corpo, para validação back end
    public class EventoController : ControllerBase
    {   //injeção de dependencia
        private readonly IRelacionaW3Repositorio _repo;
        private readonly IMapper _mapper;
        public EventoController(IRelacionaW3Repositorio repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        //requisição assincrona
        public async Task<IActionResult> Get()
        {

            try
            {
                var eventos = await _repo.GetAllEventoAsync(true);

                var results = _mapper.Map<EventoDto[]>(eventos);

                return Ok(results);

            }
            catch (System.Exception)
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
                var evento = await _repo.GetEventoAsyncById(EventoId, true);

                var results = _mapper.Map<EventoDto>(evento);

                return Ok(results);

            }
            catch (System.Exception)
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
                var eventos = await _repo.GetAllEventoAsyncByTema(tema, true);

                var results = _mapper.Map<EventoDto[]>(eventos);

                return Ok(results);

            }
            catch (System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }

        }

        [HttpPost]
        //requisição assincrona
        //via corpo e n query
        public async Task<IActionResult> Post(EventoDto model)
        {

            try
            {
                //recebe o dto realiza o mapeamento com evento do dominio e atribui o evento que é a variavel
                var evento = _mapper.Map<Evento>(model);

                _repo.Add(evento);

                if (await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                    return Created($"/api/evento/{model.Id}", _mapper.Map<EventoDto>(evento));
                }
            }
            catch (System.Exception ex) 
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

            }
            return BadRequest();

        }

        [HttpPut("{Eventoid}")]
        //requisição assincrona
        public async Task<IActionResult> Put(int EventoId, EventoDto model)
        {

            try
            {
                var evento = await _repo.GetEventoAsyncById(EventoId, false);
                if (evento == null) return NotFound();

                _mapper.Map(model, evento);

                _repo.Update(evento);

                if (await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                    return Created($"/api/evento/{model.Id}", _mapper.Map<EventoDto>(evento));
                }

            }
            catch (System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
            return BadRequest();
        }

        [HttpDelete("{Eventoid}")]
        //requisição assincrona
        public async Task<IActionResult> Delete(int EventoId)
        {

            try
            {
                var evento = await _repo.GetEventoAsyncById(EventoId, false);
                if (evento == null) return NotFound();
                _repo.Delete(evento);

                if (await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                    return Ok();
                }

            }
            catch (System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
            return BadRequest();
        }

    }
}