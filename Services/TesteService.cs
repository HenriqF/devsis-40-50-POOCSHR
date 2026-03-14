using Api.Models;

namespace Api.Services;

public class TesteService : ITesteService
{

    private readonly List<Pessoa> _pessoas;


    public TesteService()
    {
        _pessoas = new List<Pessoa>
        {
            new Atleta("Pedro"),
            new Medico("Pablo"),
            new Programador("Paulo"),
        };
    }

    public IEnumerable<Pessoa> GetAll() => _pessoas;

    public Pessoa? GetPessoa(string nome)
    {
        foreach (Pessoa p in _pessoas)
        {
            if (p.Nome.Equals(nome)) return p;
        }
        return null;
    }

    private static string Reverso(string t)
    {
        char[] arr = t.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public string emBinario(string input)
    {
        string result = "";
        int length = input.Length;

        for (int i = 0; i < length; i++)
        {
            int caractere = input[i];
            string binary_val = "";

            while (caractere > 0)
            {
                if (caractere % 2 == 0) binary_val += '0';
                else binary_val += '1';
                caractere /= 2;
            }

            result += Reverso(binary_val) + " ";
        }

        return result;
    }
}