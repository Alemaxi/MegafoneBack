using Domain.core.Repository;
using MySqlRepository.Repository;

namespace Megafone.DI
{
    public class CoreDI
    {

        public CoreDI(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IMegaFoneRepository, MegaFoneRepository>();
            services.AddScoped<IMensagemRepository, MensagemRepository>();
        }
    }
}
