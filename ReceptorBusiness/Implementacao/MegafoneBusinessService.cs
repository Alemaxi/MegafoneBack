using Domain.core.DTO.Megafone;
using Domain.core.Repository;
using Domain.Usuario.Business;
using MySqlRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioBusiness.Implementacao
{
    public class MegafoneBusinessService: IMegafoneBusiness
    {
        IMegaFoneRepository _repository;

        public MegafoneBusinessService(IMegaFoneRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MensageiroMegafoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro)
        {
            var result = await _repository.FiltrarMegaFonesPorMensageiro(idMensageiro);

            return result;
        }

        public async Task<CriarMegafoneDTO?> CriarMegaFone(CriarMegafoneDTO megaFone)
        {
            var resultado = await _repository.CriarMegaFone(megaFone);

            return resultado;
        }

        public async Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor)
        {
            return await _repository.ObterMegaFonesPorReceptorId(idReceptor);
        }

        public async Task CadastrarEmMegafone(CadastrarEmMegafoneDTO cadastrar)
        {
            await _repository.CadastrarEmMegafone(cadastrar);
            return;
        }
    }
}
