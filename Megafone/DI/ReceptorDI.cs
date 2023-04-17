using Domain.Usuario.Application;
using Domain.Usuario.Business;
using ReceptorBusiness.Implementacao;
using UsuarioApplication.Implementacao;

namespace Megafone.DI
{
    public class ReceptorDI
    {
        public ReceptorDI(IServiceCollection services)
        {
            services.AddScoped<IUsuarioApplication, UsuarioApplicationService>();
            services.AddScoped<IUsuarioBusiness, UsuarioBusinessService>();
        }
    }
}
