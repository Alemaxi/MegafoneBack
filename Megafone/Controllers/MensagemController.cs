using Domain.core.DTO;
using Domain.Usuario.Application;
using Domain.Usuario.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Megafone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensagemController : ControllerBase
    {
        IMensagemApplication _application;

        public MensagemController(IMensagemApplication application)
        {
            _application = application;
        }

        [HttpGet("{megafoneId}")]
        public Task<IEnumerable<MensagemDTO>> ObterMensagensPorMegafoneId(int megafoneId)
        {
            return _application.ObterMensagemPorIdMegaFone(megafoneId);
        }
    }
}
