namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio usuarioRepositorio, UsuarioValidador usuarioValidador, Hashing hashing) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public void Ejecutar(Usuario usuario)
    {

        if (!usuarioValidador.Validar(usuario, out string mensajeErorr))
        {
            throw new ValidacionException(mensajeErorr);
        }
        usuario.Contraseña = hashing.Hashear(usuario.Contraseña);
        RepositorioUsu.ModificarUsuario(usuario);


    }

}
