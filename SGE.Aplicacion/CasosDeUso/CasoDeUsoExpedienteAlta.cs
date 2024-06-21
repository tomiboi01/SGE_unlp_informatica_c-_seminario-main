namespace SGE.Aplicacion
{
    public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repositorio, IServicioAutorizacion servicioAutorizacion, ExpedienteValidador expValidador) : AbstractCasoDeUsoExpediente(repositorio)
    {
        public void Ejecutar(int idUsuario, Expediente expediente)
        {
            if (!servicioAutorizacion.PoseeElPermiso(idUsuario, Permiso.ExpedienteAlta))
            {
                throw new AutorizacionExcepcion("No posee el permiso");
            }
            if (!expValidador.Validar(expediente, idUsuario, out string mensajeError))
            {
                throw new ValidacionException(mensajeError);
            }
            expediente.FechaCreacion = DateTime.Now;
            expediente.FechaUltModificacion = DateTime.Now;
            expediente.UsuarioUltModificacion = idUsuario;
            expediente.Estado = EstadoExpediente.RecienIniciado;
            RepositorioExp.Alta(expediente);
        }
    }
}
