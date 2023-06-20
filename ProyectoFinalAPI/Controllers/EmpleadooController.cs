using Microsoft.AspNetCore.Mvc;
using ProyectoFinalAPI.Data;
using ProyectoFinalAPI.Models;
using System;
using System.Linq;

namespace ProyectoFinalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public EmpleadosController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET api/empleados
        [HttpGet]
        public IActionResult GetEmpleados()
        {
            var empleados = _dbContext.Empleados.ToList();
            return Ok(empleados);
        }

        // GET api/empleados/{id}
        [HttpGet("{id}")]
        public IActionResult GetEmpleado(int id)
        {
            var empleado = _dbContext.Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }
            return Ok(empleado);
        }

        // POST api/empleados
        [HttpPost]
        public IActionResult AddEmpleado([FromBody] Empleadoo empleado)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Empleados.Add(empleado);
                _dbContext.SaveChanges();
                return CreatedAtAction(nameof(GetEmpleado), new { id = empleado.Id }, empleado);
            }
            return BadRequest(ModelState);
        }

        // PUT api/empleados/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateEmpleado(int id, [FromBody] Empleadoo empleado)
        {
            if (id != empleado.Id)
            {
                return BadRequest();
            }

            var existingEmpleado = _dbContext.Empleados.FirstOrDefault(e => e.Id == id);
            if (existingEmpleado == null)
            {
                return NotFound();
            }

            existingEmpleado.Nombre = empleado.Nombre;
            existingEmpleado.UserName = empleado.UserName;
            existingEmpleado.Password = empleado.Password;

            _dbContext.SaveChanges();
            return NoContent();
        }

        // DELETE api/empleados/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmpleado(int id)
        {
            var empleado = _dbContext.Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }

            _dbContext.Empleados.Remove(empleado);
            _dbContext.SaveChanges();
            return NoContent();
        }

        // GET api/empleados/username/{id}
        [HttpGet("username/{id}")]
        public IActionResult GetEmpleadoByUserName(int id)
        {
            var empleado = _dbContext.Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }
            var empleadoUserName = new { empleado.UserName };
            return Ok(empleadoUserName);
        }

        // GET api/empleados/password/{id}
        [HttpGet("password/{id}")]
        public IActionResult GetEmpleadoByPassword(int id)
        {
            var empleado = _dbContext.Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }
            var empleadoPassword = new { empleado.Password };
            return Ok(empleadoPassword);
        }

    }

}

