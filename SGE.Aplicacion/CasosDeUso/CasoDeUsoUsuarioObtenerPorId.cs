using SGE.Aplicacion;

namespace SGE.Aplicacion;
public class CasoDeUsoUsuarioObtenerPorId(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public Usuario Ejecutar(int id)
    {
        return RepositorioUsu.ObtenerUsuario(id);
    }

}