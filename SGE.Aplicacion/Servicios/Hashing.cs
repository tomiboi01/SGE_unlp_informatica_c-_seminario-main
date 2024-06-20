namespace SGE.Aplicacion;
using System.Security.Cryptography;
using System.Text;
public class Hashing
{
    public static string Hashear(string st)
    {
        return Encoding.UTF8.GetString(SHA256.HashData(Encoding.UTF8.GetBytes(st)));
    }
}