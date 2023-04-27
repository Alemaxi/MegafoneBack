using Domain.Usuario.Application;
using Domain.Usuario.Business;
using UsuarioApplication.Implementacao;
using UsuarioBusiness.Implementacao;

namespace Megafone.DI
{
    public class MegafoneDI
    {
        public MegafoneDI(IServiceCollection services) {
            services.AddScoped<IMegafoneApplication, MegafoneApplicationService>();
            services.AddScoped<IMegafoneBusiness, MegafoneBusinessService>();
        }
    }
}
