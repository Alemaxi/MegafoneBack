using Domain.core.DTO;
using Domain.Usuario.Application;
using Domain.Usuario.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioApplication.Implementacao
{
    public class MensagemApplicationService: IMensagemApplication
    {
        IMensagemBusiness _business;

        public MensagemApplicationService(IMensagemBusiness business)
        {
            _business = business;
        }

        public Task<IEnumerable<MensagemDTO>> ObterMensagemPorIdMegaFone(int idMegaFone)
        {
            return _business.ObterMensagemPorIdMegaFone(idMegaFone);
        }
    }
}
