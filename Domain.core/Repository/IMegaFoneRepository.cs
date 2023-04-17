using Domain.core.DTO;

namespace Domain.core.Repository
{
    public interface IMegaFoneRepository
    {
        //obter MegaFone por id
        public Task<MegaFoneDTO> ObterMegaFonePorId(int id);
        //filtrar Megafones por nome
        public Task<IEnumerable<MegaFoneDTO>> FiltrarMegaFonesPorNome(string nome);
        //filtrar MegaFone por Mensageiro
        public Task<IEnumerable<MegaFoneDTO>> FiltrarMegaFonesPorMensageiro(int idMensageiro);
        public Task<IEnumerable<MegaFoneDTO>> ObterMegaFonesPorReceptorId(int idReceptor);
        //criar Megafone
        public Task<MegaFoneDTO?> CriarMegaFone(MegaFoneDTO megaFone);
        //Atualiza MegaFone
        public Task<MegaFoneDTO?> AtualizarMegaFone(MegaFoneDTO megaFone);
        //remover Megafone
        public Task<MegaFoneDTO?> RemoverMegaFone(MegaFoneDTO megaFone);
    }
}
