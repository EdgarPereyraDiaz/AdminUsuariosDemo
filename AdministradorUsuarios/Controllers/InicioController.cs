using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Authorization;

namespace AdministradorUsuarios.Controllers
{
    /// <summary>
    /// Controlador de la vista inicial
    /// </summary>
    public class InicioController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
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
