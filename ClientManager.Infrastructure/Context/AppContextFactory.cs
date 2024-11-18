using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientManager.Domain.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace ClientManager.Infrastructure.Context
{
    public class AppContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=meu_banco;Username=user;Password=123456");

            return new AppDbContext(optionsBuilder.Options);
        }
    }

}
