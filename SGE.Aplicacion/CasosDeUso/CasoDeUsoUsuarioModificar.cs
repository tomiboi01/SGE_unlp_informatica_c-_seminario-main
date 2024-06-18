namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public void Ejecutar(int idUsuario, Usuario usuario)
    {
        if (!UsuarioValidador.Validar(usuario, out string mensajeErorr))
        {
            throw new ValidacionException(mensajeErorr);
        }

        RepositorioUsu.ModificarUsuario(usuario);


    }

}
