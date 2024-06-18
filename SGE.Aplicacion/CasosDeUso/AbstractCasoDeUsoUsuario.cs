namespace SGE.Aplicacion;

public abstract class AbstractCasoDeUsoUsuario(IUsuarioRepositorio usuarioRepositorio)
{
    protected IUsuarioRepositorio RepositorioUsu { get; } = usuarioRepositorio;

    
}
