using AnalisadorDados.API.Dto;
using AnalisadorDados.Core.Entities;

using Microsoft.AspNetCore.Mvc;

namespace AnalisadorDados.API.Controllers;

[Route("[Controller]")]
[ApiController]
public class CadastraUsuarioController : ControllerBase
{
    private readonly ILogger<CadastraUsuarioController> _logger;
    private readonly IUsuarioCRUD _usuarioCRUD;

    public CadastraUsuarioController(ILogger<CadastraUsuarioController> logger, IUsuarioCRUD usuarioCrud)
    {
        _logger = logger;
        _usuarioCRUD = usuarioCrud;
    }

    [HttpPost]
    [Route("/user")]
    public async Task<IActionResult> CriaUsuario(List<UsuarioCriacaoDto> listaUsuario)
    {
        foreach (var usuarioCriacao in listaUsuario)
        {
            var usuario = UsuarioCriacaoDto.ToEntity(usuarioCriacao);
            
            await _usuarioCRUD.GravarUsuario(usuario);
        }
        
        var retorn = new UsuarioCriacaoRetorno("Arquivo recebido com sucesso.", listaUsuario.Count);
        return Ok(retorn);
    }
    
}