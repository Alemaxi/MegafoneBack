using Domain.core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuario.Business
{
    public interface IUsuarioBusiness
    {
        Task AdicionarReceptor(UsuarioDTO receptor);
        //Atualizar Receptor
        Task AtualizarReceptor(UsuarioDTO receptor);
        //Obter receptor por id
        UsuarioDTO ObterReceptor(int id);
        UsuarioDTO ObterReceptor(string email);
    }
}
