using Domain.core.DTO;
using Domain.Usuario.Application;
using Domain.Usuario.Business;

namespace UsuarioApplication.Implementacao
{
    public class UsuarioApplicationService: IUsuarioApplication
    {
        readonly IUsuarioBusiness _business;

        public UsuarioApplicationService(IUsuarioBusiness business)
        {
            _business = business;
        }

        public Task AdicionarReceptor(UsuarioDTO receptor)
        {
            _business.AdicionarReceptor(receptor); 
            return Task.CompletedTask;
        }

        public Task AtualizarReceptor(UsuarioDTO receptor)
        {
            _business.AtualizarReceptor(receptor);
            return Task.CompletedTask;
        }

        public UsuarioDTO ObterReceptor(int id)
        {
            return _business.ObterReceptor(id);
        }

        public UsuarioDTO ObterReceptor(string email)
        {
            return _business.ObterReceptor(email);
        }
    }
}
