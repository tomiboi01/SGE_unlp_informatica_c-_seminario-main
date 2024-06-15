using SGE.Aplicacion;

namespace SGE.Aplicacion;
public class CasoDeUsoObtenerUsuario(IUsuarioRepositorio usuarioRepositorio)
{
    public Usuario Ejecutar(string nombre, string contraseña)
    {
        return usuarioRepositorio.ObtenerUsuario(nombre, contraseña);
    }
    public Usuario Ejecutar(int idUsuario)
    {
        return usuarioRepositorio.ObtenerUsuario(idUsuario);
    }
}