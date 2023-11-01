﻿using Biblioteca.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoInicial.Models;
using ProyectoInicial.Services;
using System.Reflection;

namespace ProyectoInicial.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Iconsumo _consumo;

        public ClienteController(Iconsumo consumo)
        {
            _consumo = consumo;
        }
       

        [HttpPost]
        public async Task<IActionResult> Index(string usuarioP, string clave)
        {
            List<Usuario> usuario = await _consumo.GetUsuarios();
            bool credencialesValidas = usuario.Any(u => u.UsuarioP == usuarioP && u.Contrasena == clave);

            if (credencialesValidas)
            {
                return View();

            }
            else
            {
                
                return RedirectToAction("Index", "Home");
            }

        }
        
        public async Task<IActionResult> Index()
        {

            return View();

        }
        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
