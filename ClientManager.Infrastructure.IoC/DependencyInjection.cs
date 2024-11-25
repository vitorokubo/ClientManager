using ClientManager.Application.Interfaces;
using ClientManager.Application.Mappings;
using ClientManager.Application.Services;
using ClientManager.Domain.Account;
using ClientManager.Domain.Interfaces;
using ClientManager.Infrastructure.Context;
using ClientManager.Infrastructure.Data.Identity;
using ClientManager.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
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
            b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)),ServiceLifetime.Scoped);


            services.AddIdentityCore<ApplicationUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddSignInManager()
                .AddDefaultTokenProviders();
               

            services.AddScoped<IAuthenticate, AuthenticateService>();
            services.AddScoped<ISeedUserRoleInitial, SeedUserRoleInitial>();


            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IVendaRepository, VendaRepository>();

            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IVendaService, VendaService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));   

            return services;
        }
    }
}
