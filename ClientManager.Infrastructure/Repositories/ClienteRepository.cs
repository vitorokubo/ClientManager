using ClientManager.Domain.Entities;
using ClientManager.Domain.Interfaces;
using ClientManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Infrastructure.Repositories
{
    public class ClienteRepository : IClienteRepository
    {

        AppDbContext _clienteContext;

        public ClienteRepository(AppDbContext context)
        {
            _clienteContext = context;
        }

        public async Task<Cliente> CreateAsync(Cliente Cliente)
        {
            _clienteContext.Add(Cliente);
            await _clienteContext.SaveChangesAsync();
            return Cliente;
        }

        public async Task<Cliente?> GetByIdAsync(int? id)
        {
            return await _clienteContext.Clientes
                          .FindAsync(id);
        }

        public async Task<List<Cliente>> GetClientesAsync()
        {
            return await _clienteContext.Clientes.ToListAsync();
        }

        public async Task<Cliente> RemoveAsync(Cliente Cliente)
        {
            _clienteContext.Remove(Cliente);
            await _clienteContext.SaveChangesAsync();
            return Cliente;
        }

        public async Task<Cliente> UpdateAsync(Cliente Cliente)
        {

            _clienteContext.Update(Cliente);

          
            await _clienteContext.SaveChangesAsync();
            return Cliente;
        }
    }
}
