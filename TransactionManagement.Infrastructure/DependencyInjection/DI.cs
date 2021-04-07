using Microsoft.Extensions.DependencyInjection;
using TransactionManagement.Core.Entities.PersonAggregate;
using TransactionManagement.Core.Interfaces;
using TransactionManagement.Core.Interfaces.Repositories;
using TransactionManagement.Core.Interfaces.Services;
using TransactionManagement.Core.Services;
using TransactionManagement.Infrastructure.Repositories;

namespace TransactionManagement.Infrastructure.DependencyInjection
{
    public static class DI
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services
                .AddScoped<IPersonRepository, PersonRepository>()
                .AddScoped<IDocumentTypeRepository, DocumentTypeRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IBankRepository, BankRepository>()
                .AddScoped<IBankService,BankService>();

            return services;
        }
    }
}
