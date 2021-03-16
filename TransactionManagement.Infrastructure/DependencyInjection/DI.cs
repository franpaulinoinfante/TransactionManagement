using Microsoft.Extensions.DependencyInjection;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Infrastructure.Repositories;

namespace TransactionManagement.Infrastructure.DependencyInjection
{
    public static class DI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddScoped<IPersonRepository, PersonRepository>()
                .AddScoped<IIncumbentRepository, IncumbentRepository>()
                .AddScoped<IDocumentTypeRepository,DocumentTypeRepository>();

            return services;
        }
    }
}
