using Domain.core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Repository
{
    public interface IMensagemRepository
    {
        //Obter mensagem por Id
        Task<MensagemDTO> ObterMensagemPorId(int id);
        //Obter mensagem por IdMegaFone
        Task<IEnumerable<MensagemDTO>> ObterMensagemPorIdMegaFone(int idMegaFone);
        //Adicionar Mensagem
        Task<MensagemDTO> AdicionarMensagem(MensagemDTO mensagem);
        //Atualizar Mensagem
        Task<MensagemDTO> AtualizarMensagem(MensagemDTO mensagem);
        //Deletar Mensagem
        Task<MensagemDTO> DeletarMensagem(MensagemDTO mensagem);
    }
}
