using APILibros.Data;
using APILibros.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APILibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventarioLibrosController : ControllerBase
    {

        private readonly AppDBContext _db;

        public InventarioLibrosController(AppDBContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Libros> libro = await _db.libros.ToListAsync();
            return Ok(libro);
        }


        [HttpGet("{IdLibro}")]
        public async Task<IActionResult> Get(int IdLibro)
        {
            Libros libro = await _db.libros.FirstOrDefaultAsync(x => x.IdLibro == IdLibro);
            if (libro != null)
            {
                return Ok(libro);
            }
            return BadRequest();

        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Libros libro)
        {
            Libros libro2 = await _db.libros.FirstOrDefaultAsync(x => x.IdLibro == libro.IdLibro);
            if (libro2 == null && libro != null)
            {
                await _db.libros.AddAsync(libro);
                await _db.SaveChangesAsync();
                return Ok(libro);
            }
            return BadRequest("No se pudo crear el producto");

        }


        [HttpPut("{IdLibros}")]
        public async Task<IActionResult> Put(int IdLibro, [FromBody] Libros libro)
        {
            Libros libro2 = await _db.libros.FirstOrDefaultAsync(x => x.IdLibro == IdLibro);
            if (libro2 != null)
            {
                libro2.Nombre = libro.Nombre != null ? libro.Nombre : libro2.Nombre;
                libro2.Autor = libro.Autor != null ? libro.Autor : libro2.Autor;
                libro2.Cantidad = libro.Cantidad != null ? libro.Cantidad : libro2.Cantidad;
                libro2.Precio = libro.Precio != null ? libro.Precio : libro2.Precio;
                _db.libros.Update(libro2);
                await _db.SaveChangesAsync();
                return Ok(libro2);
            }
            return BadRequest();

        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{IdLibro}")]
        public async Task<IActionResult> Delete(int IdLibro)
        {
            Libros libro = await _db.libros.FirstOrDefaultAsync(x => x.IdLibro == IdLibro);
            if (libro != null)
            {
                _db.libros.Remove(libro);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest("No se pudo borrar el producto");
        }
    }
}
