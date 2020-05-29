using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdministradorUsuarios.Controllers
{
    /// <summary>
    /// Controlador para la administración de roles; crear, actualizar o eliminar
    /// </summary>
    [Authorize(Roles = "Administrador")]
    public class RolesController : Controller
    {
        private readonly ILogger _Logger;
        private readonly RoleManager<IdentityRole> rolesManager;
        private readonly UserManager<AppUsuarios> userManager;
        public RolesController(RoleManager<IdentityRole> rolesMgr, UserManager<AppUsuarios> usuarioMrg, ILogger<RolesController> logger)
        {
            _Logger = logger;
            rolesManager = rolesMgr;
            userManager = usuarioMrg;
        }

        public ViewResult Index() => View(rolesManager.Roles);

        public IActionResult Agregar() => View();

        [HttpPost]
        public async Task<IActionResult> Agregar([Required] string name)
        {
            if (ModelState.IsValid)
            {
                IdentityResult resultado = await rolesManager.CreateAsync(new IdentityRole(name));
                if (resultado.Succeeded)
                    return RedirectToAction("Index");
                else
                    Error(resultado);
            }
            if (string.IsNullOrEmpty(name))
            {
                ModelState.AddModelError("", "Nombre de rol no puede estar vacío.");
            }
            return View(name);
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(string id)
        {
            IdentityRole rol = await rolesManager.FindByIdAsync(id);
            if (rol != null)
            {
                IdentityResult resultado = await rolesManager.DeleteAsync(rol);
                if (resultado.Succeeded)
                {
                    _Logger.LogInformation("Se elimino el rol " + rol.Name);
                    return RedirectToAction("Index");
                }
                else
                {
                    Error(resultado);
                }
            }
            else
                ModelState.AddModelError("", "No se pudo encontrar Rol");
            return View("Index", rolesManager.Roles);
        }

        public async Task<IActionResult> Actualizar(string id)
        {
            IdentityRole role = await rolesManager.FindByIdAsync(id);
            List<AppUsuarios> miembros = new List<AppUsuarios>();
            List<AppUsuarios> NoMiembros = new List<AppUsuarios>();
            foreach (AppUsuarios usuario in userManager.Users)
            {
                var list = await userManager.IsInRoleAsync(usuario, role.Name) ? miembros : NoMiembros;
                list.Add(usuario);
            }
            return View(new EditarRoles
            {
                Role = role,
                Members = miembros,
                NonMembers = NoMiembros
            });
        }

        [HttpPost]
        public async Task<IActionResult> Actualizar(ModificacionRoles model)
        {
            IdentityResult resultado;
            if (ModelState.IsValid)
            {
                foreach (string userId in model.AddIds ?? new string[] { })
                {
                    AppUsuarios usuario = await userManager.FindByIdAsync(userId);
                    if (usuario != null)
                    {
                        resultado = await userManager.AddToRoleAsync(usuario, model.RoleName);
                        if (!resultado.Succeeded)
                            Error(resultado);
                    }
                }
                foreach (string userId in model.DeleteIds ?? new string[] { })
                {
                    AppUsuarios usuario = await userManager.FindByIdAsync(userId);
                    if (usuario != null)
                    {
                        resultado = await userManager.RemoveFromRoleAsync(usuario, model.RoleName);
                        if (!resultado.Succeeded)
                            Error(resultado);
                    }
                }
            }

            if (ModelState.IsValid)
                return RedirectToAction(nameof(Index));
            else
                return await Actualizar(model.RoleId);
        }

        private void Error(IdentityResult resultado)
        {
            foreach (IdentityError error in resultado.Errors)
                ModelState.AddModelError("", error.Description);
        }
    }
}
