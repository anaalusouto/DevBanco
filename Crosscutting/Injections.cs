using ClienteCRUD.Core.Interfaces.Adapters;
using ClienteCRUD.Core.UseCase.AdicionarCliente;
using ClienteCRUD.Core.UseCase.AtualizarCliente;
using ClienteCRUD.Infra.Repositories;
using ClienteCRUD.Infra.Repositories.Interfaces;
using System.Runtime.CompilerServices;

namespace ClienteCRUD.Crosscutting
{
    public static class Injections
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            #region USE CASES

            services.AddScoped<IUseCaseAdicionarCliente, UseAdicionarCliente>();
            services.AddScoped<IUseCaseAtualizarCliente, UseAtualizarCliente>();
            services.AddScoped<IUseCaseBuscarCliente, UseBuscarCliente>();

            #endregion

            #region REPOSITORIES
            services.AddScoped<IClienteRepository, ClienteRepository>();
            #endregion

            return services;
        }
    }
}
