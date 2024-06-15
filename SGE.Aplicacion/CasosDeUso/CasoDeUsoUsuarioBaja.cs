using SGE.Aplicacion;

namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioBaja(IUsuarioRepositorio usuarioRepositorio)
{
    public void Ejecutar(int idUsuario)
    {
        if (idUsuario != 1)
        {
            throw new AutorizacionExcepcion("Solo el administrador puede dar de baja a un usuario");
        }
        usuarioRepositorio.Baja(idUsuario);

    }

}
