﻿namespace SGE.Aplicacion;

public class CasoDeUsoTramiteBaja(ITramiteRepositorio tramiteRepositorio, IExpedienteRepositorio expedienteRepositorio, IServicioAutorizacion servicioAutorizacion, IEspecificacionCambioDeEstado especificacionCambioDeEstado, ServicioActualizacionEstado servicioActualizacionEstado) : AbstractCasoDeUsoTramite(tramiteRepositorio)
{
    private IServicioAutorizacion ServicioDeAutorizacion { get; } = servicioAutorizacion;

    public void Ejecutar(int usuario, int idTramite)
    {
        if (!ServicioDeAutorizacion.PoseeElPermiso(usuario, Permiso.TramiteBaja))
            throw new AutorizacionExcepcion("No posee el permiso");

        RepositorioTram.Baja(idTramite, out int idExpediente);
        servicioActualizacionEstado.ActualizarEstado(RepositorioTram, expedienteRepositorio, especificacionCambioDeEstado, idExpediente, usuario);
    }
}



