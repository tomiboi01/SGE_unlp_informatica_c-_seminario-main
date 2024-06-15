namespace SGE.Aplicacion;

public class CasoDeUsoUsuarioModificar(IUsuarioRepositorio usuarioRepositorio)
{
    public void Ejecutar(int idUsuario, Usuario usuario)
    {
        if (!UsuarioValidador.Validar(usuario, out string mensajeErorr))
        {
            throw new ValidacionException(mensajeErorr);
        }


    }

}
