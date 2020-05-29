using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdministradorUsuarios.Etiquetas
{
    /// <summary>
    /// Clase para ayudar a las etiquetas en los roles y mostrar usuarios en <td>
    /// *Necesario agregar la referencia a _ViewImports
    /// </summary>
    [HtmlTargetElement("td", Attributes = "i-role")]
    public class RolUsuarios : TagHelper
    {
        private readonly UserManager<AppUsuarios> userManager;
        private readonly RoleManager<IdentityRole> rolManager;

        public RolUsuarios(UserManager<AppUsuarios> usrmgr, RoleManager<IdentityRole> rolmgr)
        {
            userManager = usrmgr;
            rolManager = rolmgr;
        }

        [HtmlAttributeName("i-role")]
        public string Roles { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> nombres = new List<string>();
            IdentityRole rol = await rolManager.FindByIdAsync(Roles);
            if (rol != null)
            {
                foreach (var usuario in userManager.Users)
                {
                    if (usuario != null && await userManager.IsInRoleAsync(usuario, rol.Name))
                        nombres.Add(usuario.UserName);
                }
            }
            output.Content.SetContent(nombres.Count == 0 ? "Sin usuarios" : string.Join(", ", nombres));
        }
    }
}
