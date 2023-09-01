using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Web;
using System.Web.Mvc;
using WebProjeto1.Models;

namespace WebProjeto1.Controllers
{
    public class UsuarioController : Controller
    {
        // Direcionando para a view :)
        // GET: Usuario
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }

        // Recebendo as informações da view :)
        [HttpPost]

        public ActionResult Index(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado:", cliente);
            }
            return View(cliente);
        }

        public ActionResult Resultado(Cliente cliente)
        {
            return View(cliente);
        }
    }
}