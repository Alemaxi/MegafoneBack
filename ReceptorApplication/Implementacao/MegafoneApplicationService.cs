using Domain.core.DTO.Megafone;
using Domain.Usuario.Application;
using Domain.Usuario.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioApplication.Implementacao
{
    public class MegafoneApplicationService: IMegafoneApplication
    {
        IMegafoneBusiness _business;

        public MegafoneApplicationService(IMegafoneBusiness business)
        {
            _business = business;
        }

        public async Task<IEnumerable<MensageiroMegafoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro)
        {
            var result = await _business.FiltrarMegaFonesPorMensageiro(idMensageiro);

            return result;
        }

        public async Task<CriarMegafoneDTO?> CriarMegaFone(CriarMegafoneDTO megaFone)
        {
            var resultado = await _business.CriarMegaFone(megaFone);

            return resultado;
        }

        public async Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor)
        {
            return await _business.ObterMegaFonesPorReceptorId(idReceptor);
        }

        public async Task CadastrarEmMegafone(CadastrarEmMegafoneDTO cadastrar)
        {
            await _business.CadastrarEmMegafone(cadastrar);

            return;
        }
    }
}
