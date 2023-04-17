using Domain.core.DTO;
using MegafoneUnitTest.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegafoneUnitTest.Repository
{
    public class MegaFoneRepositoryTest: IClassFixture<RepositoryFixture>
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
            var inserido = await _fixture._megaFoneRepository.CriarMegaFone(new MegaFoneDTO { Nome = "MegaFone criado", idMensageiro=2});

            var resultado = await _fixture._megaFoneRepository.ObterMegaFonePorId(inserido.Id.Value);

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
    }
}