namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioObtenerTodos(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public List<Usuario> Ejecutar()
    {
        return RepositorioUsu.ObtenerUsuarios();
    }
}

