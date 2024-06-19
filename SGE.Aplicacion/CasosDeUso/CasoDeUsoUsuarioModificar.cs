namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public void Ejecutar(int idUsuario, Usuario usuario)
    {
        if (idUsuario != 1)
        {
            throw new AutorizacionExcepcion("No tiene permisos para modificar el usuario");
        }
        
        if (!UsuarioValidador.Validar(usuario, out string mensajeErorr))
        {
            throw new ValidacionException(mensajeErorr);
        }

        RepositorioUsu.ModificarUsuario(usuario);


    }

}
