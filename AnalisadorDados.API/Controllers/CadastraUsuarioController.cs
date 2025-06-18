using AnalisadorDados.API.Dto;
using AnalisadorDados.Repository.Entities;

using Microsoft.AspNetCore.Mvc;

using Action = AnalisadorDados.API.Dto.Action;

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
            USER usuario = new()
            {
                Id = usuarioCriacao.Id,
                Name = usuarioCriacao.Name,
                Age = usuarioCriacao.Age,
                Score = usuarioCriacao.Score,
                Active = usuarioCriacao.Active,
                Country = usuarioCriacao.Country,
                Team = new TEAM()
                {
                    Name = usuarioCriacao.Team.Name,
                    Leader = usuarioCriacao.Team.Leader,
                    // Projects = usuarioCriacao.Team.Projects.Select(x => x.Name).ToList()
                } 
            };
            
            await _usuarioCRUD.GravarUsuario(usuario);
        }
        
        var retorn = new UsuarioCriacaoRetorno("Arquivo recebido com sucesso.", listaUsuario.Count);
        return Ok(retorn);
    }
    
}