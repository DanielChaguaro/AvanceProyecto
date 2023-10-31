using APILibros.Data;
using APILibros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APILibros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly AppDBContext _db;

        public UsuarioController(AppDBContext db)
        {
            _db = db;
        }
        // GET: UsuarioController
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Usuario> usuarios = await _db.usuarios.ToListAsync();
            return Ok(usuarios);
        }
        [HttpGet("{IdUsuario}")]
        public async Task<IActionResult> Get(int IdUsuario)
        {
            Usuario usuarios = await _db.usuarios.FirstOrDefaultAsync(x => x.IdUsuario == IdUsuario);
            if (usuarios != null)
            {
                return Ok(usuarios);
            }
            return BadRequest();

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            Usuario usuario2 = await _db.usuarios.FirstOrDefaultAsync(x => x.IdUsuario == usuario.IdUsuario);
            if (usuario2 == null && usuario != null)
            {
                await _db.usuarios.AddAsync(usuario);
                await _db.SaveChangesAsync();
                return Ok(usuario);
            }
            return BadRequest("No se pudo crear el producto");

        }

        [HttpPut("{IdUsuario}")]
        public async Task<IActionResult> Put(int IdUsuario, [FromBody] Usuario usuario)
        {
            Usuario usuario2 = await _db.usuarios.FirstOrDefaultAsync(x => x.IdUsuario == IdUsuario);
            if (usuario2 != null)
            {
                usuario2.Nombre = usuario.Nombre != null ? usuario.Nombre : usuario2.Nombre;
                usuario2.Apellido = usuario.Apellido != null ? usuario.Apellido : usuario2.Apellido;
                usuario2.Perfil = usuario.Perfil != null ? usuario.Perfil : usuario2.Perfil;
                usuario2.UsuarioP = usuario.UsuarioP != null ? usuario.UsuarioP : usuario2.UsuarioP;
                usuario2.Contrasena = usuario.Contrasena != null ? usuario.Contrasena : usuario2.Contrasena;
                _db.usuarios.Update(usuario2);
                await _db.SaveChangesAsync();
                return Ok(usuario2);
            }
            return BadRequest();

        }
        // DELETE api/<ProductoController>/5
        [HttpDelete("{IdUsuario}")]
        public async Task<IActionResult> Delete(int IdUsuario)
        {
            Usuario usuario = await _db.usuarios.FirstOrDefaultAsync(x => x.IdUsuario == IdUsuario);
            if (usuario != null)
            {
                _db.usuarios.Remove(usuario);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest("No se pudo borrar el producto");
        }
        [HttpGet("{UsuarioP}&{Contrasena}")]
        public async Task<IActionResult> GetUsuario(string UsuarioP, string Contrasena)
        {
            Usuario usuario = await _db.usuarios.Where(x => x.UsuarioP == UsuarioP && x.Contrasena == Contrasena).FirstOrDefaultAsync();
            if (usuario != null)
            {
                return Ok(usuario);
            }
            return BadRequest();

        }

    }
}
