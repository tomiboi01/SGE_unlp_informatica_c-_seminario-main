namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioAlta(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{

    public void Ejecutar(int idUsuario, Usuario usuario)
    {
        if (idUsuario != 1)
        {
            throw new AutorizacionExcepcion("Solo el administrador puede dar de alta usuarios");
        }
        if (!UsuarioValidador.Validar(usuario, out string mensajeError))
        {
            throw new ValidacionException(mensajeError);
        }
        usuario.Contraseña = Hashing.Hashear(usuario.Contraseña);
        RepositorioUsu.Alta(usuario);
    }

}
