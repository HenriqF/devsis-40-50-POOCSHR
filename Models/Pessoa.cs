namespace Api.Models;

public abstract class Pessoa
{
    public string Nome { get; set; }
    public int Escovadas;

    protected Pessoa(string nome)
    {
        Nome = nome;
        Escovadas = 0;
    }

    public abstract string profissao();

    public int escovarOsDentes() => ++Escovadas;
}