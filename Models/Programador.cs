namespace Api.Models;

public class Programador : Pessoa
{

    public Programador(string Nome) : base(Nome) { }


    public override string profissao() => $"{Nome} é programador";
}
