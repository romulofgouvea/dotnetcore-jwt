using jwt.Data.Infra.Context;
using jwt.Data.Infra.Repository;
using jwt.Domain.Interfaces;
using jwt.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace jwt.Application.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            // Infra - Data
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddScoped<ApplicationContext>();

        }
    }
}
