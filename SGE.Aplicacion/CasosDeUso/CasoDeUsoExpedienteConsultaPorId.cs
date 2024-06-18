namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaPorId(IExpedienteRepositorio expedienteRepositorio, ITramiteRepositorio tramiteRepositorio) : AbstractCasoDeUsoExpediente(expedienteRepositorio)
{
    public Expediente Ejecutar(int id)
    {

        Expediente expediente = RepositorioExp.BuscarPorId(id);
        expediente.Tramites = tramiteRepositorio.ListarTodosDeIdExpediente(id);
        return expediente;
    }
}
