using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Megafone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MegaFoneController : ControllerBase
    {

        #region Métodos Para Receptor
        //Endpoint para obter lista de MegaFones por Receptor
        [HttpGet("Usuario/ObterMegafones")]
        async public Task<IActionResult> ObterMegaFones()
        {
            return Ok();
        }

        #endregion Métodos Para Receptor
    }
}
