using Domain.core.DTO;
using Domain.core.Entity;
using MegafoneUnitTest.Fixture;
using MySqlRepository;

namespace MegafoneUnitTest.Repository
{
    [Collection("RepositoryFixture")]
    public class UsuarioRepositoryTest
    {
        RepositoryFixture _fixture;

        public UsuarioRepositoryTest(RepositoryFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void AdicionarUmUsuario()
        {
            var receptor = new UsuarioDTO { Email = "Email para teste", Nome = "Nome para teste" };

            _fixture._repository.AdicionarReceptor(receptor);

            var salvo = _fixture._context.Usuarios.FirstOrDefault(x => x.Email == receptor.Email);
            Assert.Equal(salvo.Nome, receptor.Nome);
            
        }

        [Fact]
        public void AtualizarUmUsuario()
        {
            var receptor = new UsuarioDTO { Id = 1, Email = "Email atualizado", Nome= "Nome atualizado" };

            _fixture._repository.AtualizarReceptor(receptor);

            var receptorAtualizado = _fixture._repository.ObterReceptor(receptor.Id);

            Assert.Equal(receptor.Nome, receptorAtualizado.Nome);
        }

        [Fact]
        public void ObterUmUsuario()
        {
            var receptor = _fixture._repository.ObterReceptor(1);

            Assert.NotNull(receptor);
        }

        [Fact]
        public void ObterUmUsuarioPorEmail()
        {
            var receptor = _fixture._repository.ObterReceptor("EmailTest1");

            Assert.NotNull(receptor);
        }
    }
}
