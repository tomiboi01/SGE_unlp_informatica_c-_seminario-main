namespace SGE.Aplicacion;

public class CasoDeUsoTramiteModificacion(ITramiteRepositorio tramiteRepositorio, IExpedienteRepositorio expedienteRepositorio, IServicioAutorizacion servicioAutorizacion, IEspecificacionCambioDeEstado especificacionCambioDeEstado) : AbstractCasoDeUsoTramite(tramiteRepositorio)
{
    public void Ejecutar(int usuario, Tramite tramite)
    {
        if (!servicioAutorizacion.PoseeElPermiso(usuario, Permiso.TramiteModificacion))
            throw new AutorizacionExcepcion("No posee el permiso");

        if (!TramiteValidador.Validar(tramite, usuario, out string mensajeError))
            throw new ValidacionException(mensajeError);

        tramite.FechaUltModificacion = DateTime.Now;
        tramite.UsuarioUltModificacion = usuario;
        tramite.FechaCreacion = DateTime.Now;
        RepositorioTram.Modificar(tramite);
        //Con la primera condición evaluamos si el trámite que modificamos es el último y si no lo es, no se actualiza el estado del expediente.
        Tramite? auxiliar = RepositorioTram.BuscarUltimo(tramite.ExpedienteId);
        if (auxiliar?.Id == tramite.Id)
            ServicioActualizacionEstado.ActualizarEstado(RepositorioTram, expedienteRepositorio, especificacionCambioDeEstado, tramite.ExpedienteId, usuario);

    }

}

