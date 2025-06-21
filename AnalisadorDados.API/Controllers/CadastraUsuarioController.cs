using AnalisadorDados.Application.Dto;

using Microsoft.AspNetCore.Mvc;

namespace AnalisadorDados.API.Controllers;

[Route("[Controller]")]
[ApiController]
public class CadastraUsuarioController : ControllerBase
{
    private readonly ILogger<CadastraUsuarioController> _logger;
    private readonly IUsuarioCRUD _usuarioCrud;

    public CadastraUsuarioController(ILogger<CadastraUsuarioController> logger, IUsuarioCRUD usuarioCrud)
    {
        _logger = logger;
        _usuarioCrud = usuarioCrud;
    }

    [HttpPost]
    [Route("/user")]
    public async Task<IActionResult> CriaUsuario(List<UsuarioCriacaoDto> listaUsuario)
    {
        foreach (var usuarioCriacao in listaUsuario)
        {
            var usuario = UsuarioCriacaoDto.ToEntity(usuarioCriacao);
            
            await _usuarioCrud.GravarUsuario(usuario);
        }
        
        var retorn = new UsuarioCriacaoRetorno("Arquivo recebido com sucesso.", listaUsuario.Count);
        return Ok(retorn);
    }
    
}