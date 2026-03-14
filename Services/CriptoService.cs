using System.Security.Cryptography;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Api.Services;

public class CriptoService : ICriptoService
{
    private static string Compute(string d){
        if (d == null || d == "") return "falha";

        byte[] data = Encoding.UTF8.GetBytes(d);
        byte[] outb = SHA1.HashData(data);
        
        return BitConverter.ToString(outb).Replace("-", "").ToLower();
    } 

    public string sha1(string input)
    {
        
        return Compute(input);
    }
}