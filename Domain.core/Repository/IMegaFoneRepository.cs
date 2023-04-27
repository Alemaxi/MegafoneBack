using Domain.core.DTO.Megafone;

namespace Domain.core.Repository
{
    public interface IMegaFoneRepository
    {
        //obter MegaFone por id
        public Task<MegaFoneDTO> ObterMegaFonePorId(int id);
        //filtrar Megafones por nome
        public Task<IEnumerable<MegaFoneDTO>> FiltrarMegaFonesPorNome(string nome);
        //filtrar MegaFone por Mensageiro
        public Task<IEnumerable<MensageiroMegafoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro);
        //obter megafones usando o id do receptor
        public Task<IEnumerable<ReceptorMegafoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor);
        //criar Megafone
        public Task<CriarMegafoneDTO?> CriarMegaFone(CriarMegafoneDTO megaFone);
        //cadastrar receptor a um megafone
        public Task CadastrarEmMegafone(CadastrarEmMegafoneDTO cadastrar);
        //Atualiza MegaFone
        public Task<MegaFoneDTO?> AtualizarMegaFone(MegaFoneDTO megaFone);
        //remover Megafone
        public Task<MegaFoneDTO?> RemoverMegaFone(MegaFoneDTO megaFone);
    }
}
