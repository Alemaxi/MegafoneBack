using Domain.core.DTO;
using Domain.core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlRepository.Repository
{
    public class MensagemRepository: IMensagemRepository
    {
        public Task<MensagemDTO> ObterMensagemPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MensagemDTO> ObterMensagemPorIdMegaFone(int idMegaFone)
        {
            throw new NotImplementedException();
        }

        public Task<MensagemDTO> AdicionarMensagem(MensagemDTO mensagem)
        {
            throw new NotImplementedException();
        }

        public Task<MensagemDTO> AtualizarMensagem(MensagemDTO mensagem)
        {
            throw new NotImplementedException();
        }

        public Task<MensagemDTO> DeletarMensagem(MensagemDTO mensagem)
        {
            throw new NotImplementedException();
        }
    }
}
