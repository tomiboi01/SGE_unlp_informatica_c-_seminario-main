
namespace SGE.Repositorios;
using System.Collections.Generic;
using SGE.Aplicacion;
using System.Security.Cryptography;
using System.Text;

public class UsuarioSqlite : IUsuarioRepositorio
{
    readonly SGEContext _context = new();
    public void Alta(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
    }
    public void Baja(int Id)
    {
        var user = _context.Usuarios.Find(Id);
        if (user != null)
        {
            _context.Usuarios.Remove(user);
            _context.SaveChanges();
        }
        else
            throw new RepositorioException("Usuario no encontrado");
    }
    public void ModificarUsuario(Usuario usuario)
    {
        var user = _context.Usuarios.Find(usuario.Id);
        if (user != null)
        {
            user.Nombre = usuario.Nombre;
            user.Contraseña = usuario.Contraseña;
            user.Apellido = usuario.Apellido;
            user.CorreoElectronico = usuario.CorreoElectronico;
            _context.SaveChanges();
        }
        else
            throw new RepositorioException("Usuario no encontrado");
    }
    public Usuario ObtenerUsuario(string correo, string contraseña)
    {
        var user = _context.Usuarios.Where(x => x.CorreoElectronico == correo && x.Contraseña == contraseña).FirstOrDefault();
        if (user != null)
        {
            return user;
        }
        throw new RepositorioException("Usuario no encontrado");
    }

    public bool existeUsuarioConCorreo(string correo)
    {
        var user = _context.Usuarios.Where(x => x.CorreoElectronico == correo).FirstOrDefault();
        if (user != null)
        {
            return true;
        }
        return false;

    }
    public Usuario ObtenerUsuario(int Id)
    {
        var user = _context.Usuarios.Find(Id);
        if (user != null)
        {
            return user;
        }
        throw new RepositorioException("Usuario no encontrado");
    }
    public List<Usuario> ObtenerUsuarios()
    {
        return _context.Usuarios.ToList();
    }
    public void OtorgarPermiso(Usuario usuario, Permiso permiso)
    {
        var user = _context.Usuarios.Find(usuario.Id);
        if (user != null)
        {
            user.Permisos[(int)permiso] = true;
            _context.SaveChanges();
        }
        else
            throw new RepositorioException("Usuario no encontrado");
    }


}