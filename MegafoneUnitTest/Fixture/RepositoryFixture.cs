using Domain.core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MySqlRepository;
using MySqlRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegafoneUnitTest.Fixture
{
    public class RepositoryFixture: IDisposable
    {
        public MysqlContext _context;
        public UsuarioRepository _repository;
        public MegaFoneRepository _megaFoneRepository;
        public MensagemRepository _mensagemRepository;

        public RepositoryFixture()
        {
            var options = new DbContextOptionsBuilder<MysqlContext>()
                .UseInMemoryDatabase(databaseName: "Teste")
                .Options;
            _context = new MysqlContext(options);

            MockParaReceptorRepository();
            MockParaMegaFoneRepository();
            MockParaMensagemRepository();
        }

        public void MockParaReceptorRepository()
        {
            _context.Usuarios.Add(new Usuario { Id = 1, Nome = "Teste1", Email = "EmailTest1" });
            _context.Usuarios.Add(new Usuario { Id = 2, Nome = "Teste2", Email = "EmailTest2" });
            _context.Usuarios.Add(new Usuario { Id = 3, Nome = "Teste3", Email = "EmailTest3" });

            _context.Usuarios.Add(new Usuario { Id = 4, Nome = "TestandoMegafone1", Email = "EmailTest1" });
            _context.Usuarios.Add(new Usuario { Id = 5, Nome = "TestandoMegafone2", Email = "EmailTest2" });
            _context.Usuarios.Add(new Usuario { Id = 6, Nome = "TestandoMegafone3", Email = "EmailTest3" });
            _context.SaveChanges();

            _repository = new UsuarioRepository(_context);
        }

        public void MockParaMegaFoneRepository()
        {
            _context.MegaFones.Add(new MegaFone { Id = 1, MensageiroId = 4, Nome = "MegaFone1" });
            _context.MegaFones.Add(new MegaFone { Id = 2, MensageiroId = 5, Nome = "MegaFone2" });
            _context.MegaFones.Add(new MegaFone { Id = 3, MensageiroId = 6, Nome = "MegaFone3" });

            _context.ReceptoresXMegaFones.Add(new ReceptorXMegaFone { MegaFoneId = 1, ReceptorId = 4 });
            _context.ReceptoresXMegaFones.Add(new ReceptorXMegaFone { MegaFoneId = 2, ReceptorId = 5 });
            _context.ReceptoresXMegaFones.Add(new ReceptorXMegaFone { MegaFoneId = 3, ReceptorId = 6 });

            _context.SaveChanges();
            _megaFoneRepository = new MegaFoneRepository(_context);
        }

        public void MockParaMensagemRepository()
        {
            _mensagemRepository = new MensagemRepository(_context);
        }

        public void Dispose()
        {
        }
    }
}
