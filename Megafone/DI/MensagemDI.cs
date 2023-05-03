using Domain.Usuario.Application;
using Domain.Usuario.Business;
using UsuarioApplication.Implementacao;
using UsuarioBusiness.Implementacao;

namespace Megafone.DI
{
    public class MensagemDI
    {

        public MensagemDI(IServiceCollection services)
        {
            services.AddScoped<IMensagemApplication, MensagemApplicationService>();
            services.AddScoped<IMensagemBusiness, MensagemBusinessService>();
        }
    }
}
