#pragma checksum "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8aab6cf6cbde3330c4fc156a92bad81863cc9af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Actualizar), @"mvc.1.0.view", @"/Views/Roles/Actualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Actualizar.cshtml", typeof(AspNetCore.Views_Roles_Actualizar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\_ViewImports.cshtml"
using AdministradorUsuarios;

#line default
#line hidden
#line 2 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\_ViewImports.cshtml"
using AdministradorUsuarios.Models;

#line default
#line hidden
#line 3 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8aab6cf6cbde3330c4fc156a92bad81863cc9af", @"/Views/Roles/Actualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99f86e7045b9d5051574717956a6c171f8f2907", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Actualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdministradorUsuarios.Controllers.EditarRoles>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
  
    ViewData["Title"] = "Actualizar Rol";

#line default
#line hidden
            BeginContext(104, 68, true);
            WriteLiteral("\r\n<h1 class=\"bg-info text-white bordeTitulo\">Actualizar Roles</h1>\r\n");
            EndContext();
            BeginContext(172, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8aab6cf6cbde3330c4fc156a92bad81863cc9af5473", async() => {
                BeginContext(215, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(229, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8aab6cf6cbde3330c4fc156a92bad81863cc9af6927", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 8 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(295, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(299, 2093, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8aab6cf6cbde3330c4fc156a92bad81863cc9af8656", async() => {
                BeginContext(319, 136, true);
                WriteLiteral("\r\n    <div class=\"Contenido\">\r\n        <div class=\"form-group text-left fadeIn first\">\r\n            <input type=\"hidden\" name=\"roleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 455, "\"", 479, 1);
#line 13 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
WriteAttributeValue("", 463, Model.Role.Name, 463, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(480, 51, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"roleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 531, "\"", 553, 1);
#line 14 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
WriteAttributeValue("", 539, Model.Role.Id, 539, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(554, 86, true);
                WriteLiteral(" />\r\n\r\n            <h3 class=\"bg-secondary p1 text-white bordeTitulo\">Agregar a rol - ");
                EndContext();
                BeginContext(641, 15, false);
#line 16 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                                                                          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(656, 66, true);
                WriteLiteral("</h3>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 18 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
                BeginContext(794, 79, true);
                WriteLiteral("                    <tr><td colspan=\"2\">Todos los usuarios agregado</td></tr>\r\n");
                EndContext();
#line 21 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(933, 64, true);
                WriteLiteral("                    <tr><th>Usuarios</th><th>Incluir</th></tr>\r\n");
                EndContext();
#line 25 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                     foreach (AppUsuarios user in Model.NonMembers)
                    {

#line default
#line hidden
                BeginContext(1089, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(1152, 13, false);
#line 28 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                           Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1165, 109, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"AddIds\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1274, "\"", 1290, 1);
#line 30 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
WriteAttributeValue("", 1282, user.Id, 1282, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1291, 69, true);
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 33 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                    }

#line default
#line hidden
#line 33 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1402, 102, true);
                WriteLiteral("            </table>\r\n\r\n            <h3 class=\"bg-secondary text-white bordeTitulo\">Eliminar de rol - ");
                EndContext();
                BeginContext(1505, 15, false);
#line 37 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                                                                         Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1520, 66, true);
                WriteLiteral("</h3>\r\n            <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 39 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                 if (Model.Members.Count() == 0)
                {

#line default
#line hidden
                BeginContext(1655, 75, true);
                WriteLiteral("                    <tr><td colspan=\"2\">Ningún usuario agregado</td></tr>\r\n");
                EndContext();
#line 42 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                }
                else
                {

#line default
#line hidden
                BeginContext(1790, 64, true);
                WriteLiteral("                    <tr><th>Usuarios</th><th>Excluir</th></tr>\r\n");
                EndContext();
#line 46 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                     foreach (AppUsuarios user in Model.Members)
                    {

#line default
#line hidden
                BeginContext(1943, 62, true);
                WriteLiteral("                        <tr>\r\n                            <td>");
                EndContext();
                BeginContext(2006, 13, false);
#line 49 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                           Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(2019, 112, true);
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"DeleteIds\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2131, "\"", 2147, 1);
#line 51 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
WriteAttributeValue("", 2139, user.Id, 2139, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2148, 69, true);
                WriteLiteral(">\r\n                            </td>\r\n                        </tr>\r\n");
                EndContext();
#line 54 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                    }

#line default
#line hidden
#line 54 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Roles\Actualizar.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(2259, 126, true);
                WriteLiteral("            </table>\r\n            <button type=\"submit\" class=\"btn btn-success\">Guardar</button>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdministradorUsuarios.Controllers.EditarRoles> Html { get; private set; }
    }
}
#pragma warning restore 1591
