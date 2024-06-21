namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio usuarioRepositorio, UsuarioValidador usuarioValidador, Hashing hashing) : AbstractCasoDeUsoUsuario(usuarioRepositorio)
{
    public void Ejecutar(Usuario usuario, string contraseñaAnterior)
    {
        //contraseña anterior tiene el hash de la contraseña vieja

        if (!usuarioValidador.Validar(usuario, out string mensajeErorr))
        {
            throw new ValidacionException(mensajeErorr);
        }
        if (usuario.Contraseña == contraseñaAnterior) //en caso de que la contraseña sea la misma no re hasheamos
            usuario.Contraseña = contraseñaAnterior;
        else
            usuario.Contraseña = hashing.Hashear(usuario.Contraseña);
        RepositorioUsu.ModificarUsuario(usuario);


    }

}
