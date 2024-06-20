
namespace SGE.Aplicacion;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public string Apellido { get; set; } = "";
    public string CorreoElectronico { get; set; } = "";
    public string Contraseña { get; set; } = "";
    public bool[] Permisos { get; set; } = new bool[6];

    public Usuario()
    {
    }
    public Usuario(string nombre, string apellido, string correoElectronico, string contraseña)
    {
        Nombre = nombre;
        Contraseña = contraseña;
        Apellido = apellido;
        CorreoElectronico = correoElectronico;
        Contraseña = contraseña;
    }


}