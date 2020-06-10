# Administración de Usuarios DEMO
## Descripción
Sistema para la administración de usuarios, con roles para acceso a las diferentes vistas.  
Contiene una vista de inicio para todos los usuario incluso usuarios no registrados, así  
como una vista para administración de usuarios y otra para la administración de roles.

#### Tecnologias utilizadas:

- [Visual Studio](https://visualstudio.microsoft.com/es/vs/community/)
- [.NET Core](https://docs.microsoft.com/es-es/dotnet/core/about)
- [Entity Frameworks](https://docs.microsoft.com/en-us/ef/core/)
- [Sql Server](https://docs.microsoft.com/es-es/sql/tools/overview-sql-tools?view=sql-server-ver15)
- [Bootstrap](https://getbootstrap.com/)

## Cómo utilizar el proyecto
### Instalación

1. Para iniciar el proyecto es necesario instalar la base de datos con el script que viene en la carpeta  
del proyecto, al ejecutarlo insertara tres usuarios con sus respectivos roles.

- Script para la base de datos en SQL Server
  ```html
    /ScriptSQLServer_UsuariosDB.sql
  ```

2. En un inicio se cuenta con cuatro usuarios para iniciar sesión y con tres roles (rol Administrador, rol Root y rol Usuario):  
 - Usuario con rol de Root; acceso total, es un usuario/rol default para crear más usuarios, se niega su edición y eliminación.  
  E-mail: root@software.mx  
  Contraseña: 89Root#  
  
 - Usuario con rol de administrador; acceso a inicio general, administrador de usuarios y administrador de roles (Acceso total).  
  E-mail: admin@software.mx  
  Contraseña: 89Adm#  

  - Usuario con rol de usuario; acceso a inicio general y administrador de usuarios (solo para editar su propia cuenta).  
  E-mail: usuario@software.mx  
  Contraseña: 89Usr#  
  
  - Usuario sin un rol asignado; solo acceso a inicio general.  
  E-mail: cliente@software.mx  
  Contraseña: 89Cli#  
  
  \*En caso de tener problemas con la conexión revisar el archivo */AdministracionUsuarios/appsettings.Development.json*  
    para cambiar la conexión.
    
- Conexión local:  
  ```html
    \"ConexionLocalUsuarios": "Server=(local); Database=UsuariosDB; Trusted_Connection=True; MultipleActiveResultSets=True"
  ```
  
- Carpeta con solución.
  ```html
    /AdministracionUsuarios/
    /AdministracionUsuarios.sln
  ```
  
3. El publicable puede ser abierto desde IIS, ya que fue probado de manera local.  

- Carpeta con publicable (publicado en modo carpeta desde visual studio).
```html
    /Publicable/
```

### Generación de logs
Dentro del proyecto y del publicable se genera una carpeta con archivos Logs{date}.txt para seguimiento  
de errores del sistema, inicio de sesión de usuarios, eliminacion de roles y eliminación de usuarios.

- Carpeta contenedora de logs desde startup.
```
 public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory LoggerFactory)
          {
            LoggerFactory.AddFile(env.ContentRootPath + "/Logs/log-{Date}.txt");
            ...
```

- Implementado en los controladores.
```
  private readonly ILogger _logger;
  ...
  _logger.LogInformation(Sesion.Correo + " inició sesión");
```

- Designado para mostrar errores del sistema.
```
  {
    "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Error",
      "Microsoft": "Error"
      }
  }
```

### Paquetes NuGet instalados
```
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.2.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.2.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="2.2.0">
    <PackageReference Include="Serilog.Extensions.Logging.File" Version="1.1.0" />
```

### Notas
Cuenta con una limitante de sesión de 30 minutos desde que el usuario inició sesión, así como redireccionamientos desde startup.  
```
    services.ConfigureApplicationCookie(opciones =>
    {
         opciones.Cookie.HttpOnly = true;
         opciones.LoginPath = "/Sesion/AccesoDenegado";
         opciones.LogoutPath = "/Sesion/SesionCerrada";
         opciones.AccessDeniedPath = "/Sesion/AccesoDenegado";
         opciones.SlidingExpiration = true;
         opciones.ExpireTimeSpan = TimeSpan.FromMinutes(30);
     });
```

