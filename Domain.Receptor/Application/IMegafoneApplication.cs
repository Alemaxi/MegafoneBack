using Domain.core.DTO.Megafone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuario.Application
{
    public interface IMegafoneApplication
    {
        public Task<IEnumerable<MensageiroMegafoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro);
        public Task<CriarMegafoneDTO?> CriarMegaFone(CriarMegafoneDTO megaFone);
        public Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor);
        public Task CadastrarEmMegafone(CadastrarEmMegafoneDTO cadastrar);
    }
}
