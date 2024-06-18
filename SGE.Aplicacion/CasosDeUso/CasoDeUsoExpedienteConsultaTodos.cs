namespace SGE.Aplicacion;

public class CasoDeUsoExpedienteConsultaTodos(IExpedienteRepositorio expedienteRepositorio) : AbstractCasoDeUsoExpediente(expedienteRepositorio)
{
    public List<Expediente> Ejecutar()
    {

        List<Expediente> lista = RepositorioExp.ListarTodos();
        return lista;
    }




}
