using APILibros.Data;
using APILibros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
/*
namespace APILibros.Controllers
{
    public class PrestamoController : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class PrestamoController : Controller
        {

            private readonly AppDBContext _db;

            public PrestamoController(AppDBContext db)
            {
                _db = db;
            }
            // GET: PrestamoController

            [HttpGet]
            public async Task<IActionResult> Get()
            {
                List<Prestamo> prestamo = await _db.prestamos.ToListAsync();
                return Ok(prestamo);
            }


            [HttpGet("{IdPrestamo}")]
            public async Task<IActionResult> Get(int IdPrestamo)
            {
                Prestamo prestamo = await _db.prestamos.FirstOrDefaultAsync(x => x.IdPrestamo == IdPrestamo);
                if (prestamo != null)
                {
                    return Ok(prestamo);
                }
                return BadRequest();

            }


            [HttpPost]
            public async Task<IActionResult> Post([FromBody] Prestamo prestamo)
            {
                Prestamo prestamo2 = await _db.prestamos.FirstOrDefaultAsync(x => x.IdPrestamo == prestamo.IdPrestamo);
                if (prestamo2 == null && prestamo != null)
                {
                    await _db.prestamos.AddAsync(prestamo);
                    await _db.SaveChangesAsync();
                    return Ok(prestamo);
                }
                return BadRequest("No se pudo crear el producto");

            }

            /*
            [HttpPut("{IdPrestamo}")]
            public async Task<IActionResult> Put(int IdPrestamo, [FromBody] Prestamo prestamo)
            {
                Prestamo prestamo2 = await _db.prestamos.FirstOrDefaultAsync(x => x.IdPrestamo == prestamo.IdPrestamo);
                if (prestamo2 != null)
                {
                    prestamo2.IdProducto = prestamo.IdProducto != null ? prestamo.IdProducto : prestamo2.IdProducto;
                    prestamo2.Cantidad = prestamo.Cantidad != null ? prestamo.Cantidad : prestamo2.Cantidad;
                    prestamo2.Cantidad = prestamo.Cantidad != null ? prestamo.Cantidad : prestamo2.Cantidad;
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
}*/
