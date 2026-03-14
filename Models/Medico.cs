namespace Api.Models;

public class Medico : Pessoa
{

    public Medico(string Nome) : base(Nome) { }


    public override string profissao() => $"{Nome} é medico";
}
