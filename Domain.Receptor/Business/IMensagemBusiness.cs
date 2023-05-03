using Domain.core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuario.Business
{
    public interface IMensagemBusiness
    {
        Task<IEnumerable<MensagemDTO>> ObterMensagemPorIdMegaFone(int idMegaFone);
    }
}
