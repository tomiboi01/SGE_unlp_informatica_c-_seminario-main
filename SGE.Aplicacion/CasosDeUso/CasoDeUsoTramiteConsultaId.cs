namespace SGE.Aplicacion;

public class CasoDeUsoTramiteConsultaId(ITramiteRepositorio tramiteRepositorio) : AbstractCasoDeUsoTramite(tramiteRepositorio)
{
    public Tramite Ejecutar(int id)
    {

        Tramite? tramite = RepositorioTram.BuscarPorId(id);
        return tramite;
    }
}
