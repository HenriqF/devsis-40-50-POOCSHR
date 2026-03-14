using Api.Models;
namespace Api.Services;

public interface ITesteService
{
    public IEnumerable<Pessoa> GetAll();

    public Pessoa? GetPessoa(string nome);

    public string emBinario(string input);
}