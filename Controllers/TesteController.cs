
using Microsoft.AspNetCore.Mvc;
using ZooApi.Services;

namespace ZooApi.Controllers;

[ApiController]
[Route("apiteste/[controller]")]
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

    [HttpGet("{name}")]
    public IActionResult GetBala(string name)
    {
        var result = _testeService.emBinario(name);
        return Ok(result);
    }
}