using Microsoft.AspNetCore.Mvc;

namespace AnalisadorDados.API.Controllers;

[Route("[controller]")]
[ApiController]
public class ValidacaoEndpoinsController : ControllerBase
{
    [HttpGet]
    [Route("/evaluation")]
    public IActionResult Validacao()
    {
        return Ok("Esse aqui tá ok");
    }
}