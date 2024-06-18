namespace SGE.Aplicacion
{

    public class CasoDeUsoUsuarioObtenerPorCorreoYContra ( IUsuarioRepositorio usuarioRepositorio ) : AbstractCasoDeUsoUsuario ( usuarioRepositorio )
    {
        public Usuario Ejecutar ( string correo, string contrasena )
        {
            return RepositorioUsu.ObtenerUsuario ( correo, contrasena );
        }
    }

}