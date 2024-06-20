namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public void Ejecutar(Usuario usuario)
    {

        if (!UsuarioValidador.Validar(usuario, out string mensajeErorr))
        {
            throw new ValidacionException(mensajeErorr);
        }
        usuario.Contraseña = Hashing.Hashear(usuario.Contraseña);
        RepositorioUsu.ModificarUsuario(usuario);


    }

}
