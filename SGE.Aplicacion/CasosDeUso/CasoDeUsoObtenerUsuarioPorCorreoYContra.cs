namespace SGE.Aplicacion
{

    public class CasoDeUsoObtenerUsuarioPorCorreoYContra ( IUsuarioRepositorio usuarioRepositorio ) 
    {
        public Usuario Ejecutar ( string correo, string contrasena )
        {
            return usuarioRepositorio.ObtenerUsuario ( correo, contrasena );
        }
    }

}