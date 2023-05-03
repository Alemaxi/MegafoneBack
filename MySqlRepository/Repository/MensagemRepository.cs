using Domain.core.DTO;
using Domain.core.DTO.Megafone;
using Domain.core.Entity;
using Domain.core.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlRepository.Repository
{
    public class MensagemRepository: IMensagemRepository
    {
        MysqlContext _context;

        public MensagemRepository(MysqlContext context)
        {
            _context = context;
        }

        public Task<MensagemDTO> ObterMensagemPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MensagemDTO>> ObterMensagemPorIdMegaFone(int idMegaFone)
        {
            var result = _context.Mensagems.AsNoTracking().Where(x => x.IdMegaFone == idMegaFone)
                .Select(x => new MensagemDTO
                {
                    Id = x.Id,
                    Assunto = x.Assunto,
                    DataCriacao = x.DataCriacao,
                    Texto= x.Texto,
                }).AsEnumerable();

            return Task.FromResult(result);
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
