using Domain.core.DTO;
using Domain.Usuario.Application;
using Microsoft.AspNetCore.Mvc;

namespace Megafone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        readonly IUsuarioApplication _application;

        public UsuarioController(IUsuarioApplication application)
        {
            _application = application;
        }

        //endpoint para obter um receptor por id
        [HttpGet("{id}")]
        public IActionResult ObterReceptor(int id)
        {
            var result = _application.ObterReceptor(id);
            
            if(result == null) { return Ok(); }

            return Ok(result);
        }

        //endpoint para Adicionar um receptor
        [HttpPost]
        public IActionResult AdicionarReceptor(UsuarioDTO receptor)
        {
            _application.AdicionarReceptor(receptor);
            return Ok();
        }

        //endpoint para Atualizar um receptor
        [HttpPut]
        public IActionResult AtualizarReceptor(UsuarioDTO receptor)
        {
            _application.AtualizarReceptor(receptor);
            return Ok();
        }
    }
}
