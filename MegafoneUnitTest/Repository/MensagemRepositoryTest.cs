using Domain.core.Entity;
using Domain.core.Enum;
using MegafoneUnitTest.Fixture;
using MySqlRepository;
using MySqlRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegafoneUnitTest.Repository
{
    [Collection("RepositoryFixture")]
    public class MensagemRepositoryTest
    {
        MensagemRepository _repository;
        RepositoryFixture _fixture;
        MysqlContext _context;

        public MensagemRepositoryTest(RepositoryFixture fixture)
        {
            _fixture = fixture;
            _repository = fixture._mensagemRepository;
            _context = fixture._context;
        }

        [Fact]
        public async void ObterMensagensPorMegafoneId()
        {
            var usuario = _context.Add(new Usuario { Nome = "Alexandre", Email = "Email@email" }).Entity;
            var megafone = _context.Add(new MegaFone
            {
                Nome = "Megafone 1",
                Descricao = "Descricao",
                MensageiroId = usuario.Id,
            }).Entity;
            _context.Mensagems.Add(new Mensagem { Assunto = "Assunto", Texto = "Texto", DataCriacao = DateTime.Now, IdMegaFone= megafone.Id, UrlRecurso="URL", Duracao=DuracaoMensagemEnum.umDia });
            _context.SaveChanges();

           var result = await _repository.ObterMensagemPorIdMegaFone((int) megafone.Id);
            var count = result.Count();
            Assert.NotEmpty(result);
        }
    }
}
