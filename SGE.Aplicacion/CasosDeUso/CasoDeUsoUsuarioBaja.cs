namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioBaja(IUsuarioRepositorio usuarioRepositorio) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public void Ejecutar(int idUsuario)
    {

        RepositorioUsu.Baja(idUsuario);

    }

}
