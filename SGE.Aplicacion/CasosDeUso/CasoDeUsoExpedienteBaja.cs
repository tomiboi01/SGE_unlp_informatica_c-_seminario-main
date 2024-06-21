namespace SGE.Aplicacion;
public class CasoDeUsoExpedienteBaja(IExpedienteRepositorio expedienteRepositorio, ITramiteRepositorio tramiteRepositorio, IServicioAutorizacion servicioAutorizacion) : AbstractCasoDeUsoExpediente(expedienteRepositorio)
{
    public void Ejecutar(int idUsuario, int idExpediente)
    {
        if (!servicioAutorizacion.PoseeElPermiso(idUsuario, Permiso.ExpedienteBaja))
            throw new AutorizacionExcepcion("No posee el permiso");
        RepositorioExp.Baja(idExpediente);
        tramiteRepositorio.BorrarTodosDeIdExpediente(idExpediente); // En caso de que no sea un repositorio de SQL, se deberá implementar un método que borre todos los trámites de un expediente
    }

}
