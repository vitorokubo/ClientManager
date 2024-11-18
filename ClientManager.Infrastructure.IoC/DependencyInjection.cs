using ClientManager.Application.Interfaces;
using ClientManager.Application.Mappings;
using ClientManager.Application.Services;
using ClientManager.Domain.Interfaces;
using ClientManager.Infrastructure.Context;
using ClientManager.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClientManager.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => 
            options.UseNpgsql(configuration.GetConnectionString("WebApiDatabase"), b => 
            b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IClienteService, ClienteService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));   


            return services;
        }
    }
}
