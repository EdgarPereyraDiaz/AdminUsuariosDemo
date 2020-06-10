using System.Threading.Tasks;
using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdministradorUsuarios.Controllers
{
    /// <summary>
    /// Controlador para el inicio de sesión de los usuarios
    /// </summary>
    [Authorize(Roles = "Administrador, Usuario")]
    public class SesionController : Controller
    {
        private readonly ILogger _logger;
        private readonly UserManager<AppUsuarios> userManager;
        private readonly SignInManager<AppUsuarios> signInManager;

        public SesionController(UserManager<AppUsuarios> usuario, SignInManager<AppUsuarios> sesion, ILogger<SesionController> logger)
        {
            _logger = logger;
            userManager = usuario;
            signInManager = sesion;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult AccesoDenegado()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult IniciarSesion(string Url)
        {
            IniciarSesion login = new IniciarSesion
            {
                ReturnUrl = Url
            };
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("~/Inicio/Index");
            }
            else
            {
                return View(login);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> IniciarSesion(IniciarSesion Sesion)
        {
            if (ModelState.IsValid)
            {
                AppUsuarios usuario = await userManager.FindByEmailAsync(Sesion.Correo);
                if (usuario != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult resultado = await signInManager.PasswordSignInAsync(usuario, Sesion.Contraseña, false, false);
                    if (resultado.Succeeded) 
                    { 
                        _logger.LogInformation(Sesion.Correo + " inició sesión");
                        return Redirect("~/Inicio/Index");
                    }
                }
                ModelState.AddModelError("", "Usuario y/o contraseña incorrectos");
                return Index();
            }
            else
            {
                ModelState.AddModelError("", "Usuario no registrado");
            }
            return Index();
        }

        [AllowAnonymous]
        public async Task<IActionResult> CerrarSesion()
        {
            await signInManager.SignOutAsync();
            return Redirect("~/Inicio/Index");
        }
    }
}
