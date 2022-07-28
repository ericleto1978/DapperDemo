using Microsoft.Extensions.DependencyInjection;
using DapperDemo.Infrastructure.Repository;
using DapperDemo.Noyau.Interfaces;

namespace DapperDemo.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void InjecterInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IEntrepriseRepository, EntrepriseRepository>();
        }
    }
}