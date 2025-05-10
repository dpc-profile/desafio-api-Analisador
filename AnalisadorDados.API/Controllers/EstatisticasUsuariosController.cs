using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnalisadorDados.API.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class EstatisticasUsuariosController : ControllerBase
    {
        private readonly ILogger<EstatisticasUsuariosController> _logger;

        public EstatisticasUsuariosController(ILogger<EstatisticasUsuariosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/superusers")]
        public async Task<IActionResult> SuperUsuarios()
        {
            return Ok("Esse aqui tá ok");
        }
        
        [HttpGet]
        [Route("/top-countries")]
        public async Task<IActionResult> TopPaises()
        {
            return Ok("Esse aqui tá ok");
        }
        
        [HttpGet()]
        [Route("/active-users-per-day")]
        public async Task<IActionResult> UsuariosAtivosPorDia([FromQuery] int? min)
        {
            return Ok("Esse aqui tá ok");
        }
    }
}
