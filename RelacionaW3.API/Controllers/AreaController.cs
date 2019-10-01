using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
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
    public class AreaController : ControllerBase
    {   //injeção de dependencia
        private readonly IRelacionaW3Repositorio _repo;
        private readonly IMapper _mapper;
        public AreaController(IRelacionaW3Repositorio repo, IMapper mapper)
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
                var areas = await _repo.GetAllAreaAsync(true);

                var results = _mapper.Map<AreaDto[]>(areas);

                return Ok(results);

            }
            catch (System.Exception ex)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

            }

        }

        [HttpGet("{AreaId}")]

        //requisição assincrona
        public async Task<IActionResult> Get(int AreaId)
        {

            try
            {
                var area = await _repo.GetAreaAsyncById(AreaId, true);

                var results = _mapper.Map<AreaDto>(area);

                return Ok(results);

            }
            catch (System.Exception ex)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

            }

        }

        [HttpGet("getByNome/{nome}")]

        //requisição assincrona
        public async Task<IActionResult> Get(string nome)
        {

            try
            {
                var areas = await _repo.GetAllAreaAsyncByNome(nome, true);

                var results = _mapper.Map<AreaDto[]>(areas);

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
        public async Task<IActionResult> Post(AreaDto model)
        {

            try
            {
                //recebe o dto realiza o mapeamento com area do dominio e atribui o area que é a variavel
                var area = _mapper.Map<Area>(model);

                _repo.Add(area);

                if (await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                    return Created($"/api/area/{model.Id}", _mapper.Map<AreaDto>(area));
                }
            }
            catch (System.Exception ex) 
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Banco de Dados Falhou {ex.Message}");

            }
            return BadRequest();

        }

        [HttpPut("{Areaid}")]
        //requisição assincrona
        public async Task<IActionResult> Put(int AreaId, AreaDto model)
        {

            try
            {

            //   var area = await _repo.GetAreaAsyncById(AreaId, false);
            //     if (area == null) return NotFound();

            //     var idLotes = new List<int>();
            //     var idRedesSociais = new List<int>();

            //     model.Lotes.ForEach(item => idLotes.Add(item.Id));
            //     model.RedesSociais.ForEach(item => idRedesSociais.Add(item.Id));

            //     var lotes = area.Lotes.Where(
            //         lote => !idLotes.Contains(lote.Id)
            //     ).ToArray();

            //     var redesSociais = area.RedesSociais.Where(
            //         rede => !idLotes.Contains(rede.Id)
            //     ).ToArray();

            //     if (lotes.Length > 0) _repo.DeleteRange(lotes);
            //     if (redesSociais.Length > 0) _repo.DeleteRange(redesSociais);
 {

            try
            {
                var area = await _repo.GetAreaAsyncById(AreaId, false);
                if (area == null) return NotFound();

                _mapper.Map(model, area);

                _repo.Update(area);

                if (await _repo.SaveChangeAsync())
                {
                    //se eu conseguir fazer um post vou dar um created
                    return Created($"/api/area/{model.Id}", _mapper.Map<AreaDto>(area));
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

        [HttpDelete("{Areaid}")]
        //requisição assincrona
        public async Task<IActionResult> Delete(int AreaId)
        {

            try
            {
                var area = await _repo.GetAreaAsyncById(AreaId, false);
                if (area == null) return NotFound();
                _repo.Delete(area);

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