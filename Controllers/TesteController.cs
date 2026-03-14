
using Microsoft.AspNetCore.Mvc;
using Api.Services;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TesteController : ControllerBase
{
    private static readonly string teste = "teste";
    private readonly ITesteService _testeService;
    public TesteController(ITesteService testeService)
    {
        _testeService = testeService;
    }


    [HttpGet(Name = "GetTeste")]
    public IActionResult Get()
    {
        return Ok(teste);
    }

    [HttpGet("binario/{name}")]
    public IActionResult GetBala(string name)
    {
        var result = _testeService.emBinario(name);
        return Ok(result);
    }


    [HttpGet("profissao/{name}")]
    public IActionResult GetPessoaProfissao(string name)
    {
        var result = _testeService.GetPessoa(name);
        if (result == null)
        {
            return Ok("null");
        }
        return Ok(result.profissao());
    }

    [HttpPost("escovar/{name}")]
    public IActionResult FazerEscovar(string name)
    {
        var result = _testeService.GetPessoa(name);
        if (result == null)
        {
            return Ok("null");
        }

        return Ok(result.escovarOsDentes());
    }
}