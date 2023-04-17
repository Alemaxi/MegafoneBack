using Domain.core.DTO;
using Domain.core.Repository;
using Domain.Usuario.Business;

namespace ReceptorBusiness.Implementacao
{
    public class UsuarioBusinessService: IUsuarioBusiness
    {
        readonly IUsuarioRepository _repository;

        public UsuarioBusinessService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public Task AdicionarReceptor(UsuarioDTO receptor)
        {
            _repository.AdicionarReceptor(receptor);
            return Task.CompletedTask;
        }

        public Task AtualizarReceptor(UsuarioDTO receptor)
        {
            _repository.AtualizarReceptor(receptor);
            return Task.CompletedTask;
        }

        public UsuarioDTO ObterReceptor(int id)
        {
            return _repository.ObterReceptor(id);
        }

        public UsuarioDTO ObterReceptor(string email)
        {
            return _repository.ObterReceptor(email);
        }
    }
}
