using AnalisadorDados.Core.Dto;

using Microsoft.AspNetCore.Mvc;

namespace AnalisadorDados.API.Controllers;

[Route("[Controller]")]
[ApiController]
public class CadastraUsuarioController : ControllerBase
{
    private readonly ILogger<CadastraUsuarioController> _logger;

    public CadastraUsuarioController(ILogger<CadastraUsuarioController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    [Route("/user")]
    public async Task<IActionResult> CriaUsuario(List<UsuarioCriacaoDto> usuarioCriacaoDto)
    {
        // Recebe o json mas se der erro não retorna nada
        
        var retorn = new UsuarioCriacaoRetorno("Arquivo recebido com sucesso.", usuarioCriacaoDto.Count);
        return Ok(retorn);
    }
    
}