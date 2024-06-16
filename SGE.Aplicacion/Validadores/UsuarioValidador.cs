namespace SGE.Aplicacion;

public class UsuarioValidador
{
    public static bool Validar(Usuario usuario, out string mensajeError)
    {
        mensajeError = "";
        if (usuario == null)
        {
            mensajeError += "El expediente no puede ser nulo.";
            return false;
        }
        if (string.IsNullOrWhiteSpace(usuario.Nombre) ||
            string.IsNullOrWhiteSpace(usuario.Apellido) ||
            string.IsNullOrWhiteSpace(usuario.CorreoElectronico) ||
            string.IsNullOrWhiteSpace(usuario.Contraseña)
        )
        {
            mensajeError += "Alguno de los datos del usuario no es válido\n";
        }
        return mensajeError == "";
    }
}