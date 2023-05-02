using Domain.core.DTO.Megafone;
using Domain.Usuario.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Megafone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MegaFoneController : ControllerBase
    {
        IMegafoneApplication _application;

        public MegaFoneController(IMegafoneApplication application)
        {
            _application = application;
        }

        [HttpGet("mensageiro/{idMensageiro}")]
        public Task<IEnumerable<MensageiroMegafoneDTO>> ObterMegafonePorIdUsuarioMensageiro([FromRoute] int idMensageiro)
        {
            var result = _application.FiltrarMegaFonesPorMensageiro(idMensageiro);

            return result;
        }

        [HttpGet("receptor/{idReceptor}")]
        public Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegafonePorIdUsuarioReceptor([FromRoute] int idReceptor)
        {
            var result = _application.ObterMegaFonesPorReceptorId(idReceptor);

            return result;
        }

        [HttpPost]
        public async Task CriarUmMegafone([FromBody] CriarMegafoneDTO megafone)
        {
            await _application.CriarMegaFone(megafone);

            return;
        }

        [HttpPost("cadastrarEmMegafone")]
        public async Task CadastrarEmMegafone([FromBody] CadastrarEmMegafoneDTO megafone)
        {
            await _application.CadastrarEmMegafone(megafone);
            return;
        }

        [HttpDelete("{id}")]
        public async Task RemoverMegafone([FromRoute]int id)
        {
            await _application.RemoverMegaFone(id);
            return;
        }
    }
}
