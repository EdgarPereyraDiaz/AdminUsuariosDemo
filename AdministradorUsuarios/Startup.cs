using AdministradorUsuarios.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace AdministradorUsuarios
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<UsuariosDbContext>(opciones =>
                opciones.UseSqlServer(Configuration.GetConnectionString("ConexionLocalUsuarios")));
            services.AddIdentity<AppUsuarios, IdentityRole>(opciones =>
            {
                //opciones politicas correo y contraseña
                opciones.Password.RequiredLength = 5;
                opciones.Password.RequireNonAlphanumeric = true;
                opciones.Password.RequireLowercase = true;
                opciones.Password.RequireUppercase = true;
                opciones.Password.RequireDigit = true;
                opciones.User.RequireUniqueEmail = true;
            })  .AddEntityFrameworkStores<UsuariosDbContext>()
                .AddDefaultTokenProviders()
                .AddErrorDescriber<DescripcionErrores>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory LoggerFactory)
        {
            LoggerFactory.AddFile(env.ContentRootPath + "/Logs/log-{Date}.txt");

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Inicio}/{action=Index}/");
            });
        }
    }
}
