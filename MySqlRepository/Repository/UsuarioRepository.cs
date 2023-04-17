using Domain.core.DTO;
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
    public class UsuarioRepository: IUsuarioRepository
    {
        readonly MysqlContext _context;

        public UsuarioRepository(MysqlContext context)
        {
            _context = context;
        }

        public Task AdicionarReceptor(UsuarioDTO receptor)
        {
            _context.Usuarios.Add(new Usuario
            {
                Nome = receptor.Nome,
                Email = receptor.Email
            });

            _context.SaveChanges();

            return Task.CompletedTask;
        }

        public Task AtualizarReceptor(UsuarioDTO receptor)
        {
            var usuario = _context.Usuarios.FirstOrDefault(x => x.Id == receptor.Id);
            usuario.Nome = receptor.Nome;
            usuario.Email = receptor.Email; 

            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public UsuarioDTO? ObterReceptor(int id)
        {
            var result = _context.Usuarios.AsNoTracking().Where(usuario => usuario.Id == id).Select(usuario => new UsuarioDTO()
            {
                Id = id,
                Email = usuario.Email,
                Nome = usuario.Nome
            }).FirstOrDefault();

            return result;
        }

        public UsuarioDTO? ObterReceptor(string email)
        {
            var result = _context.Usuarios.AsNoTracking().Where(usuario => usuario.Email.ToLower() == email.ToLower()).Select(usuario => new UsuarioDTO()
            {
                Id = usuario.Id,
                Email = usuario.Email,
                Nome = usuario.Nome
            }).FirstOrDefault();

            return result;
        }
    }
}
