namespace SGE.Aplicacion;

public abstract class AbstractCasoDeUsoTramite(ITramiteRepositorio tramiteRepositorio)
{
    protected ITramiteRepositorio RepositorioTram { get; } = tramiteRepositorio;
}