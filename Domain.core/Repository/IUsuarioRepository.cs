using Domain.core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.core.Repository
{
    public interface IUsuarioRepository
    {
        //adicionar Receptor
        Task AdicionarReceptor(UsuarioDTO receptor);
        //Atualizar Receptor
        Task AtualizarReceptor(UsuarioDTO receptor);
        //Obter receptor por id
        UsuarioDTO? ObterReceptor(int id);
        //Obter receptor por email
        UsuarioDTO? ObterReceptor(string email);
    }
}
