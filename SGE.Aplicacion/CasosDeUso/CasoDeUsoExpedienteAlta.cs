namespace SGE.Aplicacion
{
    public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repositorio, IServicioAutorizacion servicioAutorizacion) : AbstractCasoDeUsoExpediente(repositorio)
    {
        private IServicioAutorizacion ServicioDeAutorizacion { get; } = servicioAutorizacion;
        public void Ejecutar(int idUsuario, Expediente expediente)
        {
            if (!ServicioDeAutorizacion.PoseeElPermiso(idUsuario, Permiso.ExpedienteAlta))
            {
                throw new AutorizacionExcepcion("No posee el permiso");
            }
            if (!ExpedienteValidador.Validar(expediente, idUsuario, out string mensajeError))
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
