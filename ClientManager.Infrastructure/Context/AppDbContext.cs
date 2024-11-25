
using Microsoft.EntityFrameworkCore;
using ClientManager.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ClientManager.Infrastructure.Data.Identity;

namespace ClientManager.Infrastructure.Context
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ProdutoVenda> ProdutoVendas { get; set; }

    }


}
