namespace Api.Models;

public class Atleta : Pessoa
{

    public Atleta(string Nome) : base(Nome) { }


    public override string profissao() => $"{Nome} é atleta";
}
