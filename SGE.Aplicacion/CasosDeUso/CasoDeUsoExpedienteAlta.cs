﻿

namespace SGE.Aplicacion
{
    public class CasoDeUsoExpedienteAlta(IExpedienteRepositorio repositorio, IServicioAutorizacion servicioAutorizacionProvisorio) : AbstractCasoDeUsoExpediente(repositorio)
    {
        public void Ejecutar(int idUsuario, Expediente expediente)

        {
            if (!servicioAutorizacionProvisorio.PoseeElPermiso(idUsuario, Permiso.ExpedienteAlta))
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
            Repositorio.Alta(expediente);

        }
    }
}
