﻿
namespace SGE.Aplicacion;

public class CasoDeUsoTramiteAlta(ITramiteRepositorio tramiteRepositorio, IExpedienteRepositorio expedienteRepositorio, IServicioAutorizacion servicioAutorizacion, IEspecificacionCambioDeEstado especificacionCambioDeEstado) : AbstractCasoDeUsoTramite(tramiteRepositorio)
{
    private IServicioAutorizacion ServicioDeAutorizacion { get; } = servicioAutorizacion;

    public void Ejecutar(int idUsuario, Tramite tramite)
    {

        if (!ServicioDeAutorizacion.PoseeElPermiso(idUsuario, Permiso.TramiteAlta))
            throw new AutorizacionExcepcion("No posee el permiso");

        if (!TramiteValidador.Validar(tramite, idUsuario, out string mensajeError))
            throw new ValidacionException(mensajeError);

        tramite.FechaCreacion = DateTime.Now;
        tramite.FechaUltModificacion = DateTime.Now;
        tramite.UsuarioUltModificacion = idUsuario;
        RepositorioTram.Alta(tramite);

        ServicioActualizacionEstado.ActualizarEstado(RepositorioTram, expedienteRepositorio, especificacionCambioDeEstado, tramite.ExpedienteId, idUsuario);
    }
}





