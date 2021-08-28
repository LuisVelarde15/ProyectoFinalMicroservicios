using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPelicula.Helpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiPelicula.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        // GET: api/<PeliculaController>
        [HttpGet]
        public ActionResult Get()
        {
            Datos Db = new Datos();
            var Resultados = Db.Pelicula.ToList();
            return Ok(Resultados);
        }

        // POST api/<PeliculasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PeliculasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PeliculasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
