namespace SGE.Aplicacion;
public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio expedienteRepositorio, ITramiteRepositorio tramiteRepositorio, IServicioAutorizacion servicioAutorizacion) : AbstractCasoDeUsoExpediente(expedienteRepositorio)
{
    private IServicioAutorizacion ServicioDeAutorizacion {get;} = servicioAutorizacion;
    private ITramiteRepositorio TramiteRepositorio{get;} = tramiteRepositorio;
    public void Ejecutar(int idUsuario, int idExpediente)
    {
        if (!ServicioDeAutorizacion.PoseeElPermiso(idUsuario, Permiso.ExpedienteBaja))
            throw new AutorizacionExcepcion("No posee el permiso");
        RepositorioExp.Baja(idExpediente);
        TramiteRepositorio.BorrarTodosDeIdExpediente(idExpediente); // En caso de que no sea un repositorio de SQL, se deberá implementar un método que borre todos los trámites de un expediente
    }

}
