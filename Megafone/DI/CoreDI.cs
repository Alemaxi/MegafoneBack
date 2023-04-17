﻿using Domain.core.Repository;
using MySqlRepository.Repository;

namespace Megafone.DI
{
    public class CoreDI
    {

        public CoreDI(IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}