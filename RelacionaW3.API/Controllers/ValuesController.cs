using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RelacionaW3.API.Model;

namespace RelacionaW3.API.Controllers
{
    //Rota principal 
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[]{
                new Evento () {
                    EventoId = 1,
                    Tema = "RelacionaW3",
                    Local = "Ponta Grossa",
                    Lote = "1 Lote",
                    QtqPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")

                },
                new Evento () {
                    EventoId = 2,
                    Tema = "RelacionaW3-Exclusivo",
                    Local = "Curitiba",
                    Lote = "2 Lote",
                    QtqPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")

                }

            };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[]{
                new Evento () {
                    EventoId = 1,
                    Tema = "RelacionaW3",
                    Local = "Ponta Grossa",
                    Lote = "1 Lote",
                    QtqPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")

                },
                new Evento () {
                    EventoId = 2,
                    Tema = "RelacionaW3-Exclusivo",
                    Local = "Curitiba",
                    Lote = "2 Lote",
                    QtqPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")

                }
                    //evento é igual ao parametro passado a cima
            }.FirstOrDefault(options => options.EventoId == id);
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
