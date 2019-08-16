using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RelacionaW3.API.Data;
using RelacionaW3.API.Model;

namespace RelacionaW3.API.Controllers
{
    //Rota principal 
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]

        //requisição assincrona
        public async Task<IActionResult> Get()
        {

            try 
            {
                var results = await _context.Eventos.ToListAsync();
                
                return  Ok(results);

            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
            


        }

        // GET api/values/5
        [HttpGet("{id}")]
     public async Task<IActionResult> Get(int id)

        {

            try 
            {
                var results = await _context.Eventos.FirstOrDefaultAsync(options => options.EventoId == id);
                
                return  Ok(results);

            }
            catch(System.Exception)
            {
                //VERIFICA ERRO E DEPENDENDO JOGA A INFORMAÇÃO NA TELA
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados Falhou");

            }
            


        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
