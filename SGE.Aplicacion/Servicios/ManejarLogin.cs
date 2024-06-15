namespace SGE.Aplicacion.Servicios;
public class ManejarLogin(IUsuarioRepositorio usuRepo)
{
    public Usuario Logear(string usuario, string contrasena)
    {

        return usuRepo.ObtenerUsuario(usuario, contrasena);

    }

}