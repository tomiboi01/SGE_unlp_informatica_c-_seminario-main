namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioAlta(IUsuarioRepositorio usuarioRepositorio, UsuarioValidador usuarioValidador, Hashing hashing) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{

    public void Ejecutar(Usuario usuario)
    {
        if (!usuarioValidador.Validar(usuario, out string mensajeError))
        {
            throw new ValidacionException(mensajeError);
        }
        usuario.Contraseña = hashing.Hashear(usuario.Contraseña);
        RepositorioUsu.Alta(usuario);
    }

}
