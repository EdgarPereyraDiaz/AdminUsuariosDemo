# Administración de Usuarios DEMO
## Descripción
Sistema para la administración de usuarios, con roles para acceso a las diferentes vistas.  
Sontiene una vista de inicio para todos los usuario incluso usuarios no registrados, así  
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

2. En un inicio se cuenta con tres usuarios para iniciar sesión y con dos roles (rol Administrador y rol Usuario):  
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

### Paquetes NuGet instalados
```
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="2.2.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="2.2.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="2.2.0">
    <PackageReference Include="Serilog.Extensions.Logging.File" Version="1.1.0" />
```
