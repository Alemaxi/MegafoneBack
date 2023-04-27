using Domain.core.DTO.Megafone;

namespace Domain.Usuario.Business
{
    public interface IMegafoneBusiness
    {
        public Task<IEnumerable<MensageiroMegafoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro);
        public Task<CriarMegafoneDTO?> CriarMegaFone(CriarMegafoneDTO megaFone);
        public Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor);
        public Task CadastrarEmMegafone(CadastrarEmMegafoneDTO cadastrar);
    }
}
