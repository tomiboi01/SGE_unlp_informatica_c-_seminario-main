namespace SGE.Aplicacion;
public class ManejarLogin(IUsuarioRepositorio usuRepo, Hashing hashing)
{
    public Usuario Loggear(string correo, string contraseña)
    {
        contraseña = hashing.Hashear(contraseña);
        return usuRepo.ObtenerUsuario(correo, contraseña);
    }
    public bool YaExisteConCorreo(string correo)
    {
        return usuRepo.existeUsuarioConCorreo(correo);
    }


}