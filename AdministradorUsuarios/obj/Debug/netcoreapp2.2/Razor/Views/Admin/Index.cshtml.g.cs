#pragma checksum "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a66f0f58f020654e6b966006dd93713e465e738b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a66f0f58f020654e6b966006dd93713e465e738b", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c99f86e7045b9d5051574717956a6c171f8f2907", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUsuarios>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agregar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success fadeIn first"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Actualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Eliminar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Administrador de Usuarios";

#line default
#line hidden
            BeginContext(137, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
 if (Sesion.IsSignedIn(User) && User.IsInRole("Administrador"))
{

#line default
#line hidden
            BeginContext(207, 89, true);
            WriteLiteral("    <h1 class=\"bg-info text-white bordeTitulo fadeIn first\">Todos los usuarios</h1>\r\n    ");
            EndContext();
            BeginContext(296, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66f0f58f020654e6b966006dd93713e465e738b6227", async() => {
                BeginContext(357, 5, true);
                WriteLiteral("Nuevo");
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
            BeginContext(366, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(380, 86, true);
            WriteLiteral("    <h1 class=\"bg-info text-white bordeTitulo fadeIn first\">Edici&oacute;n de usuario ");
            EndContext();
            BeginContext(467, 18, false);
#line 14 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                                                                                 Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(485, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 15 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
}

#line default
#line hidden
            BeginContext(495, 92, true);
            WriteLiteral("\r\n<div class=\"Contenido\">\r\n    <table class=\"table table-sm table-bordered fadeIn second\">\r\n");
            EndContext();
#line 19 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
         if (Sesion.IsSignedIn(User) && User.IsInRole("Administrador"))
        {
            

#line default
#line hidden
#line 21 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
             foreach (AppUsuarios usuario in Model)
            {

#line default
#line hidden
            BeginContext(739, 135, true);
            WriteLiteral("                <tr><th>Nombre</th><th>E-mail</th><th>Editar</th><th>Eliminar</th></tr>\r\n                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(875, 16, false);
#line 25 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                   Write(usuario.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(891, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(923, 13, false);
#line 26 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                   Write(usuario.Email);

#line default
#line hidden
            EndContext();
            BeginContext(936, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(967, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66f0f58f020654e6b966006dd93713e465e738b10214", async() => {
                BeginContext(1049, 10, true);
                WriteLiteral("Actualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                                                                                 WriteLiteral(usuario.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1063, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1120, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66f0f58f020654e6b966006dd93713e465e738b12747", async() => {
                BeginContext(1189, 81, true);
                WriteLiteral("\r\n                            <button type=\"submit\" class=\"btn btn-sm btn-danger\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1270, "\"", 1342, 7);
                WriteAttributeValue("", 1280, "return", 1280, 6, true);
                WriteAttributeValue(" ", 1286, "confirm(\'Desea", 1287, 15, true);
                WriteAttributeValue(" ", 1301, "eliminar", 1302, 9, true);
                WriteAttributeValue(" ", 1310, "el", 1311, 3, true);
                WriteAttributeValue(" ", 1313, "usuario:", 1314, 9, true);
#line 30 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
WriteAttributeValue(" ", 1322, usuario.UserName, 1323, 17, false);

#line default
#line hidden
                WriteAttributeValue("", 1340, "\')", 1340, 2, true);
                EndWriteAttribute();
                BeginContext(1343, 43, true);
                WriteLiteral(">Elminar</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                                                      WriteLiteral(usuario.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1393, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
            }

#line default
#line hidden
#line 34 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
             
        }
        else if (Sesion.IsSignedIn(User) && User.IsInRole("Usuario"))
        {
            

#line default
#line hidden
#line 38 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
             foreach (AppUsuarios usuario in Model)
            {
                

#line default
#line hidden
#line 40 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                 if (usuario.UserName == User.Identity.Name && User.Identity.IsAuthenticated)
                {

#line default
#line hidden
            BeginContext(1735, 130, true);
            WriteLiteral("                    <tr><th>Nombre</th><th>E-mail</th><th>Editar</th></tr>\r\n                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1866, 16, false);
#line 44 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                       Write(usuario.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1882, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1918, 13, false);
#line 45 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                       Write(usuario.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1931, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1966, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a66f0f58f020654e6b966006dd93713e465e738b18542", async() => {
                BeginContext(2048, 10, true);
                WriteLiteral("Actualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                                                                                     WriteLiteral(usuario.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2062, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 48 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                }

#line default
#line hidden
#line 48 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
                 
            }

#line default
#line hidden
#line 49 "C:\Users\edgar\Desktop\AdministradorUsuarios\AdministradorUsuarios\Views\Admin\Index.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2141, 28, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUsuarios> Sesion { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUsuarios>> Html { get; private set; }
    }
}
#pragma warning restore 1591