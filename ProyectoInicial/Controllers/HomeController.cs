using ProyectoInicial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;
using ProyectoInicial.Services;

namespace Biblioteca.Controllers
{
    public class HomeController : Controller
    {
        private readonly Iconsumo _consumo;

        public HomeController(Iconsumo consumo)
        {
            _consumo = consumo;
        }

        
        [HttpPost]
        public ActionResult Login()
        {
            int i = 0;
            return null;
        }

            [HttpGet]
        public async Task<IActionResult> Index(string usuarioP,string clave)
        {
            Usuario usuarios = new Usuario();
            Usuario usuarioCreado = await _consumo.LoginUsuario(usuarioP,clave);
            if ((usuarios.UsuarioP != usuarioP) && (usuarios.Contrasena != clave))
            {
                return View("Cliente/Index");

            }
            else
            {

                ViewData["Mensaje"] = "No se pudo crear el usuario";
                return View();
            }
            

                
                //return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}