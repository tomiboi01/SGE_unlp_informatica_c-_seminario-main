namespace SGE.Aplicacion;
public class ServicioAutorizacion(IUsuarioRepositorio repositorioUsuario) : IServicioAutorizacion
{


    public bool PoseeElPermiso(int IdUsuario, Permiso permiso)
    {
        if (IdUsuario == 1)
        {
            return true;
        }
        var usuario = repositorioUsuario.ObtenerUsuario(IdUsuario);
        return usuario.Permisos[(int)permiso];
    }
}