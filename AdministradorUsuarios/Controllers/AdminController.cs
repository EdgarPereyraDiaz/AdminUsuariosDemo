using System.Threading.Tasks;
using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdministradorUsuarios.Controllers
{
    /// <summary>
    /// Controlador para la administración de usuarios; editar, actualizar o eliminar
    /// </summary>
    [Authorize(Roles = "Usuario, Administrador, Root")]
    public class AdminController : Controller
    {
        private readonly ILogger _logger;
        private readonly UserManager<AppUsuarios> userManager;
        private readonly IPasswordHasher<AppUsuarios> passwordHasher;

        public AdminController(UserManager<AppUsuarios> Usuario, IPasswordHasher<AppUsuarios> passwordHash, ILogger<AdminController> logger)
        {
            _logger = logger;
            userManager = Usuario;
            passwordHasher = passwordHash;
        }

        public IActionResult Index()
        {
            return View(userManager.Users);
        }

        public ViewResult Agregar() => View();

        [HttpPost]
        public async Task<IActionResult> Agregar(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                AppUsuarios appUsuario = new AppUsuarios
                {
                    UserName = usuario.NombreUsuario,
                    Email = usuario.Correo
                };

                IdentityResult resultado = await userManager.CreateAsync(appUsuario, usuario.Contraseña);
                if (resultado.Succeeded)
                    return RedirectToAction("Index");
                else
                {
                    Error(resultado);
                }
            }
            return View(usuario);
        }

        public async Task<IActionResult> Actualizar(string id)
        {
            AppUsuarios usuario = await userManager.FindByIdAsync(id);
            if (usuario != null)
                return View(usuario);
            else
                return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Actualizar(string id, string email, string password)
        {
            AppUsuarios usuario = await userManager.FindByIdAsync(id);
            if (usuario != null)
            {
                if (!string.IsNullOrEmpty(email))
                    if (email.Contains("@"))
                        usuario.Email = email;
                    else
                        ModelState.AddModelError("", "E-mail no válido");
                else
                    ModelState.AddModelError("", "E-mail es obligatorio");


                if (!string.IsNullOrEmpty(password))
                    usuario.PasswordHash = passwordHasher.HashPassword(usuario, password);
                else
                    ModelState.AddModelError("", "Contraseña es obligatoria");

                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && email.Contains("@"))
                {
                    IdentityResult resultado = await userManager.UpdateAsync(usuario);
                    if (resultado.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Error(resultado);
                }
            }
            else
                ModelState.AddModelError("", "Usuario no encontrado");
            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(string id)
        {
            AppUsuarios usuario = await userManager.FindByIdAsync(id);
            if (usuario != null)
            {
                IdentityResult resultado = await userManager.DeleteAsync(usuario);
                if (resultado.Succeeded)
                {
                    _logger.LogInformation("Se eliminó al usuario " + usuario.Email);
                    return RedirectToAction("Index");
                }
                else
                {
                    Error(resultado);
                }

            }
            else
                ModelState.AddModelError("", "Usuario no encontrado");
            return View("Index", userManager.Users);
        }

        private void Error(IdentityResult resultado)
        {
            foreach (IdentityError error in resultado.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
