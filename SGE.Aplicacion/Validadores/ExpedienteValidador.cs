namespace SGE.Aplicacion;

public class ExpedienteValidador
{
    public bool Validar(Expediente? expediente, int usuario, out string mensajeError)
    {
        mensajeError = "";
        if (expediente == null)
        {
            mensajeError += "El expediente no puede ser nulo.";
            return false;
        }
        if (string.IsNullOrWhiteSpace(expediente.Caratula))
        {
            mensajeError += "Carátula inválida.\n";
        }
        if (usuario <= 0)
        {
            mensajeError += "El numero de usuario debe ser mayor que cero.";
        }
        return mensajeError == "";
    }
}