using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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
            catch (System.Exception ex)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

            }

        }

        [HttpPost("upload")]
        //requisição assincrona
        public async Task<IActionResult> Post()
        {

            try
            {   
                //arquivo
                var file = Request.Form.Files[0];
                //diretorio
                var folderName = Path.Combine("Resources", "Images");
                //combinando o diretorio mais o diretorio da aplicação
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                //array maior do que zero ou seja se ele existe
                if (file.Length > 0)
                {
                    //qual é o nome do arquivo
                    var filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName;
                    //da um replace se caso vem aspas duplas e barra
                    var fullPath = Path.Combine(pathToSave, filename.Replace("\"", "").Trim());

                    using(var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);

                    }

                }


                return Ok();

            }
            catch (System.Exception ex)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}" );

            }

            return BadRequest("Erro ao tentar realizar upload");

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
            catch (System.Exception ex)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

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
            catch (System.Exception ex)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

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

            //   var evento = await _repo.GetEventoAsyncById(EventoId, false);
            //     if (evento == null) return NotFound();

            //     var idLotes = new List<int>();
            //     var idRedesSociais = new List<int>();

            //     model.Lotes.ForEach(item => idLotes.Add(item.Id));
            //     model.RedesSociais.ForEach(item => idRedesSociais.Add(item.Id));

            //     var lotes = evento.Lotes.Where(
            //         lote => !idLotes.Contains(lote.Id)
            //     ).ToArray();

            //     var redesSociais = evento.RedesSociais.Where(
            //         rede => !idLotes.Contains(rede.Id)
            //     ).ToArray();

            //     if (lotes.Length > 0) _repo.DeleteRange(lotes);
            //     if (redesSociais.Length > 0) _repo.DeleteRange(redesSociais);
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
              
            }
            catch (System.Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou " + ex.Message);
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