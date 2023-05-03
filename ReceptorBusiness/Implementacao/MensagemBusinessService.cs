using Domain.core.DTO;
using Domain.core.Repository;
using Domain.Usuario.Business;
using MySqlRepository.Repository;

namespace UsuarioBusiness.Implementacao
{
    public class MensagemBusinessService: IMensagemBusiness
    {
        IMensagemRepository _mensagemRepository;

        public MensagemBusinessService(IMensagemRepository mensagemRepository)
        {
            _mensagemRepository = mensagemRepository;
        }

        public Task<IEnumerable<MensagemDTO>> ObterMensagemPorIdMegaFone(int idMegaFone)
        {
            return _mensagemRepository.ObterMensagemPorIdMegaFone(idMegaFone);
        }
    }
}
