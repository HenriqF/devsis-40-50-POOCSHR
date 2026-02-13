
using Microsoft.AspNetCore.Mvc;
using ZooApi.Services;

namespace ZooApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CriptoController : ControllerBase
{
    private readonly ICriptoService _criptoService;
    public CriptoController(ICriptoService criptoService)
    {
        _criptoService = criptoService;
    }

    [HttpGet("sha1/{name}")]
    public IActionResult GetSha1(string name)
    {
        return Ok(_criptoService.sha1(name));
    }
}