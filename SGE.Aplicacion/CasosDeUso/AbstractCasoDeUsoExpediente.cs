namespace SGE.Aplicacion;
public abstract class AbstractCasoDeUsoExpediente(IExpedienteRepositorio expedienteRepositorio)
{
    protected IExpedienteRepositorio RepositorioExp { get; } = expedienteRepositorio;
}