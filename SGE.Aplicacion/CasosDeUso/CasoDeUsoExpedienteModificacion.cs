

namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteModificacion(IExpedienteRepositorio expedienteRepositorio, IServicioAutorizacion servicioAutorizacion) : AbstractCasoDeUsoExpediente(expedienteRepositorio)
{
    public void Ejecutar(int idUsuario, Expediente expediente)
    {
        if (!servicioAutorizacion.PoseeElPermiso(idUsuario, Permiso.ExpedienteAlta))
            throw new AutorizacionExcepcion("No posee el permiso");

        if (!ExpedienteValidador.Validar(expediente, idUsuario, out string mensajeError))
            throw new ValidacionException(mensajeError);
        expediente.FechaUltModificacion = DateTime.Now;
        expediente.UsuarioUltModificacion = idUsuario;
        RepositorioExp.Modificacion(idUsuario, expediente);//asumimos que no van a cambiar ni el id ni el estado

    }

}
