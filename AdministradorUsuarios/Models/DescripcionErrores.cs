using Microsoft.AspNetCore.Identity;

namespace AdministradorUsuarios.Models
{
    /// <summary>
    /// Define los errores (en español) heredada de IdentityErrorDescriber
    /// </summary>
    public class DescripcionErrores : IdentityErrorDescriber
    {
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError()
            {
                Code = nameof(InvalidEmail),
                Description = "La direccion de e-mail " + email + " es incorrecta"
            };
        }
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError()
            {
                Code = nameof(DuplicateEmail),
                Description =  "Ya existe una cuenta registrada con el e-mail " + email
            };
        }

        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = nameof(PasswordTooShort),
                Description = "La contraseña debe tener almenos " + length + " caracteres"
            };
        }
        public override IdentityError PasswordMismatch()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordMismatch),
                Description = "Contraseña no incorrecta"
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = "La contraseña debe contener un símbolo"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "La contraseña debe contener un número"
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresLower),
                Description = "La contraseña debe contener una letra minúscula"
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "La contraseña debe contener una letra mayúscula"
            };
        }


        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError()
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = "El usuario ya tiene una contraseña"
            };
        }

        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = nameof(DuplicateUserName),
                Description = "El nombre de usuario " + userName + " ya existe, ingresar uno diferente"
            };
        }

        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError()
            {
                Code = nameof(UserAlreadyInRole),
                Description = "El usuario ya tiene asignado el rol " + role
            };
        }

        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError()
            {
                Description = "Ya existe un usuario con este nombre "
            };
        }

        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError()
            {
                Code = nameof(InvalidUserName),
                Description = "El nombre de usuario " + userName + "No es válido"
            };
        }

        public override IdentityError InvalidToken()
        {
            return new IdentityError()
            {
                Code = nameof(InvalidToken),
                Description = "El código de acceso es invalido"
            };
        }

        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError()
            {
                Code = nameof(InvalidRoleName),
                Description = "Nombre del rol " + role + " no es valido"
            };
        }

        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError()
            {
                Code = nameof(UserNotInRole),
                Description = "El usuario no tiene asignado el rol " + role
            };
        }

        public override IdentityError DefaultError()
        {
            return new IdentityError()
            {
                Code = nameof(DefaultError),
                Description = "Ocurrio un error inesperado, contactar con el administrador "
            };
        }

        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError()
            {
                Code = nameof(DuplicateRoleName),
                Description = "El nombre de rol " + role + " ya existe"
            };
        }

        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError()
            {
                Description = "Ocurrió un error, modificacion ya realizada"
            };
        }
    }
}
