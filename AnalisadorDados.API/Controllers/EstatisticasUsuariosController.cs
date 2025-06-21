using AnalisadorDados.Application.Dto;
using AnalisadorDados.Core.Dto;

using Microsoft.AspNetCore.Mvc;

namespace AnalisadorDados.API.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class EstatisticasUsuariosController : ControllerBase
    {
        private readonly ILogger<EstatisticasUsuariosController> _logger;
        private readonly IUsuarioCRUD _usuarioCrud;
        

        public EstatisticasUsuariosController(ILogger<EstatisticasUsuariosController> logger, IUsuarioCRUD usuarioCrud)
        {
            _logger = logger;
            _usuarioCrud = usuarioCrud;
        }

        [HttpGet]
        [Route("/superusers")]
        public IActionResult SuperUsuarios()
        {
            // Filtro: score >= 900 e active = true
            // Retorna os dados e o tempo de processamento da requisição em ms.
            // Retornar timestamp da requisição
            
            var superUsers = _usuarioCrud.RetornaSuperUser().ToList();

            var times = _usuarioCrud.RetornarTimes().ToList();

            var retornoUsuario = UsuarioCriacaoDto.ToDto(superUsers);
            
            var retorno = new UsuarioRetornoSuperUsers(DateTime.Now,  retornoUsuario);
            
            return Ok(retorno);
            
        }
        
        [HttpGet]
        [Route("/top-countries")]
        public async Task<IActionResult> TopPaises()
        {
            // Agrupa os superusuários por país.
            // Retorna os 5 países com maior número de superusuários.
            // Retornar tempo de processamento da requisição em ms e timestamp da requisição
            
            return Ok("Esse aqui tá ok");
        }
        
        [HttpGet]
        [Route("/team-insights")]
        public async Task<IActionResult> InformacoesTimes()
        {
            // Agrupa por team.name.
            // Retorna: total de membros, líderes, projetos concluídos e % de membros ativos.
            // Retornar tempo de processamento da requisição em ms e timestamp da requisição
            
            return Ok("Esse aqui tá ok");
        }
        
        [HttpGet()]
        [Route("/active-users-per-day")]
        public async Task<IActionResult> UsuariosAtivosPorDia([FromQuery] int? min)
        {
            // Conta quantos logins aconteceram por data.
            // Query param opcional: ?min=3000 para filtrar dias com pelo menos 3.000 logins.
            // Retornar tempo de processamento da requisição em ms e timestamp da requisição
            
            return Ok("Esse aqui tá ok");
        }
        
        
    }
}
