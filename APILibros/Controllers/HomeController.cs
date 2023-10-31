using APILibros.Data;
using APILibros.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace APILibros.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly AppDBContext _db;

        public HomeController(AppDBContext db)
        {
            _db = db;
        }

        
        // GET: UsuarioController


        /*public async Task<Usuario> LoginUsuarios(string usuarioP, string contrasena)
        {
            Usuario usuario = await _db.usuarios.Where(x => x.UsuarioP=>usuarioP && x.Contrasena=>contrasena).FirstOrDefeultAsync();
            return Ok(usuario);
        }*/
        // GET: HomeController
        /*[HttpPost("{UsuarioP}&{Contrasena}")]
        public async Task<IActionResult> Index(string UsuarioP,string Contrasena)
        {
            Usuario usuario = await _db.usuarios.Where(x => x.UsuarioP == UsuarioP && x.Contrasena==Contrasena).FirstOrDefaultAsync();
            if (usuario != null)
            {
                return Ok(usuario);
            }
            return BadRequest();

        }*/
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
