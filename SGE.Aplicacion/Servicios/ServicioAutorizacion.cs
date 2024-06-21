namespace SGE.Aplicacion;
public class ServicioAutorizacion(IUsuarioRepositorio repositorioUsuario) : IServicioAutorizacion
{
    public bool PoseeElPermiso(int IdUsuario, Permiso permiso)
    {
        var usuario = repositorioUsuario.ObtenerUsuario(IdUsuario);
        if (usuario.Id == 1)
        {
            return true;
        }

        return usuario.Permisos[(int)permiso];
    }

}