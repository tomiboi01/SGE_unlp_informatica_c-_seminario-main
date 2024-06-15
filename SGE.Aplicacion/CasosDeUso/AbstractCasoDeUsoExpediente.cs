namespace SGE.Aplicacion;
public abstract class AbstractCasoDeUsoExpediente(IExpedienteRepositorio expedienteRepositorio)
{
    protected IExpedienteRepositorio Repositorio { get; } = expedienteRepositorio;
}