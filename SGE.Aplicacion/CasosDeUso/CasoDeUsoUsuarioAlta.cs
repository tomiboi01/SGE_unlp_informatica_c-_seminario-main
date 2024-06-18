using SGE.Aplicacion;
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

        RepositorioUsu.Alta(usuario);
    }

}
