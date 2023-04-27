using Domain.core.DTO.Megafone;
using MegafoneUnitTest.Fixture;

namespace MegafoneUnitTest.Repository
{
    [Collection("RepositoryFixture")]
    public class MegaFoneRepositoryTest
    {

        private readonly RepositoryFixture _fixture;

        public MegaFoneRepositoryTest(RepositoryFixture fixture)
        {
            _fixture = fixture;
        }


        [Fact]
        public void ObterUmMegaFonePorId()
        {
            var megafone = _fixture._megaFoneRepository.ObterMegaFonePorId(1);

            Assert.NotNull(megafone);
        }

        [Fact]
        public async void ObterUmMegaFonePorNome()
        {
            var megafones = await _fixture._megaFoneRepository.FiltrarMegaFonesPorNome("MegaFone1");

            Assert.NotEmpty(megafones);
        }

        [Fact]
        public async void ObterUmMegaFonePorMensageiro()
        {
            var megafones = await _fixture._megaFoneRepository.FiltrarMegaFonesPorMensageiro(5);

            Assert.NotEmpty(megafones);
        }

        [Fact]
        public async void ObterUmMegaFonesPorIdReceptor()
        {
            var megafones = await _fixture._megaFoneRepository.ObterMegaFonesPorReceptorId(4);

            Assert.NotEmpty(megafones);
        }

        [Fact]
        public async void CriarMegaFone()
        {
            var inserido = await _fixture._megaFoneRepository.CriarMegaFone(new CriarMegafoneDTO { Nome = "MegaFone criado", idMensageiro=2, Descricao="Descricao"});

            var resultado = await _fixture._megaFoneRepository.FiltrarMegaFonesPorNome("MegaFone criado");

            Assert.NotNull(resultado);
        }

        [Fact]
        public async void AtualizarMegaFone()
        {
            var inserido = await _fixture._megaFoneRepository.AtualizarMegaFone(new MegaFoneDTO {Id=2, Nome = "MegaFone atualizado", idMensageiro = 2 });
        
            var resultado = await _fixture._megaFoneRepository.ObterMegaFonePorId(inserido.Id.Value);
        }

        [Fact]
        public void RemoverMegaFone()
        {
            var removido = _fixture._megaFoneRepository.RemoverMegaFone(new MegaFoneDTO { Id = 2, Nome = "MegaFone atualizado", idMensageiro = 2 });

            var resultado = _fixture._megaFoneRepository.ObterMegaFonePorId(2);

            Assert.Null(resultado);
        }

        [Fact]
        public async void CadastrarEmMegafone()
        {
            await _fixture._megaFoneRepository.CadastrarEmMegafone(new CadastrarEmMegafoneDTO
            {
                idMegafone= 1,
                idReceptor= 1,
            });

            var result =  await _fixture._megaFoneRepository.ObterMegaFonesPorReceptorId(1);

            Assert.NotEmpty(result);
        }
    }
}