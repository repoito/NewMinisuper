using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalAPI.Data;
using ProyectoFinalAPI.Models;
using ProyectoFinalAPI.Repositories;
using ProyectoFinalAPI.Repositories.IRepository;

namespace ProyectoFinalAPI.Controllers
{
    namespace MiProyecto.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class ProductosController : ControllerBase
        {
            private readonly AppDbContext _context;

            public ProductosController(AppDbContext context)
            {
                _context = context;
            }

            // GET: api/Productos
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
            {
                return await _context.Productos.ToListAsync();
            }

            // GET: api/Productos/{id}
            [HttpGet("{id}")]
            public async Task<ActionResult<Producto>> GetProductoById(int id)
            {
                var producto = await _context.Productos.FindAsync(id);
                if (producto == null)
                {
                    return NotFound();
                }

                return producto;
            }


            // POST: api/Productos
            [HttpPost]
            public async Task<ActionResult<Producto>> AddProducto(Producto producto)
            {
                _context.Productos.Add(producto);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetProductos), new { id = producto.IdProducto }, producto);
            }

            // DELETE: api/Productos/{id}
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteProducto(int id)
            {
                var producto = await _context.Productos.FindAsync(id);
                if (producto == null)
                {
                    return NotFound();
                }

                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            // PUT: api/Productos/{id}
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateProducto(int id, Producto producto)
            {
                if (id != producto.IdProducto)
                {
                    return BadRequest();
                }

                _context.Entry(producto).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }

            private bool ProductoExists(int id)
            {
                return _context.Productos.Any(p => p.IdProducto == id);
            }
        }


    }
}
