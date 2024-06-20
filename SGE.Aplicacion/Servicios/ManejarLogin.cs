namespace SGE.Aplicacion;
public class ManejarLogin(IUsuarioRepositorio usuRepo)
{
    public Usuario Loggear(string correo, string contraseña)
    {
        contraseña = Hashing.Hashear(contraseña);
        return usuRepo.ObtenerUsuario(correo, contraseña);
    }
    public Usuario Loggear(string Id)
    {
        int id = int.Parse(Id);

        return usuRepo.ObtenerUsuario(id);
    }


}