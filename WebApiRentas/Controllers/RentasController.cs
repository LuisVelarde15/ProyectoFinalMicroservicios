using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiRentas.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiRentas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentasController : ControllerBase
    {
        // GET: api/<RentaController>
        [HttpGet]
        public ActionResult Get()
        {
            Datos Db = new Datos();
            var Resultados = Db.Renta.ToList();
            return Ok(Resultados);
        }

        // GET api/<RentasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RentasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RentasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RentasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
