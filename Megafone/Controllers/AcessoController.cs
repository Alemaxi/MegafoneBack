using Domain.core.DTO;
using Domain.Usuario.Application;
using Microsoft.AspNetCore.Mvc;

namespace Megafone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcessoController : ControllerBase
    {
        IUsuarioApplication _application;

        public AcessoController(IUsuarioApplication application)
        {
            _application = application;
        }

        [HttpPost("EntrarUsuario/{email}")]
        public Task<UsuarioDTO> EntrarReceptor([FromRoute]string email)
        {
            var resultado = _application.ObterReceptor(email);
            
            return Task.FromResult(resultado);
        }
    }
}
