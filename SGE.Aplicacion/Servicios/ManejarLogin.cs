namespace SGE.Aplicacion.Servicios;
public class ManejarLogin(IUsuarioRepositorio usuRepo)
{
    public Usuario Loggear(string correo, string contrasena) => usuRepo.ObtenerUsuario(correo, contrasena);

    public Usuario Loggear(string Id)
    {
        int id = int.Parse(Id);
        return usuRepo.ObtenerUsuario(id);
    }


}