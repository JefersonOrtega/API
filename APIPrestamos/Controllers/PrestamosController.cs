using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPrestamos.BLL;
using APIPrestamos.Models;
using Microsoft.AspNetCore.Mvc;
using APIPrestamos.BLL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIPrestamos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        // GET: api/<PrestamosController>
        [HttpGet]
        public ActionResult<List<Prestamos>> Get()
        {
            return PrestamosBLL.GetPrestamos();
        }

        // GET api/<PrestamosController>/5
        [HttpGet("{id}")]
        public ActionResult<Prestamos> Get(int id)
        {
            var encontrado = PrestamosBLL.Buscar(id);

            if(encontrado == null)
            {
                return NotFound();
            }

            return encontrado;
        }

        // POST api/<PrestamosController>
        [HttpPost]
        public ActionResult<Prestamos> Post(Prestamos prestamo)
        {
            bool guardo;
            guardo = PrestamosBLL.Guardar(prestamo);
            return CreatedAtAction(nameof(Get), new { id = prestamo.PrestamoId }, prestamo);
        }

        // PUT api/<PrestamosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, Prestamos prestamo)
        {
            bool modifico;

            if (id != prestamo.PrestamoId)
                return BadRequest();

            modifico = PrestamosBLL.Modificar(prestamo);

            return NoContent();

        }

        // DELETE api/<PrestamosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var prestamo = PrestamosBLL.Buscar(id);

            if (prestamo == null)
            {
                return NotFound();
            }

            bool elimino = PrestamosBLL.Eliminar(id);

            return NoContent();
        }
    }
}
